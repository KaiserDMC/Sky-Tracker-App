namespace SkyTracker.Web.Controllers;

using System.Text;

using Azure.Storage.Blobs;

using Configuration;

using Data.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using ViewModels.AccountManagement;

using static Common.GeneralApplicationContants;
using static Configuration.UploadBlob;

[Authorize]
public class AccountManagementController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly BlobServiceClient _blobServiceClient;
    private readonly IWebHostEnvironment _hostingEnvironment;

    public AccountManagementController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, BlobServiceClient blobServiceClient, IWebHostEnvironment hostingEnvironment)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _blobServiceClient = blobServiceClient;
        _hostingEnvironment = hostingEnvironment;
    }

    [TempData]
    public string StatusMessage { get; set; }

    [HttpGet]
    public async Task<IActionResult> ProfileDisplay()
    {
        var user = await _userManager.GetUserAsync(User);

        if (user == null)
        {
            return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        }

        ProfileDisplayModel model = new ProfileDisplayModel()
        {
            UserId = user.Id.ToString(),
            Username = user.UserName,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber,
            ProfilePictureUrl = user.ProfilePictureUrl
        };

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> UploadProfilePicture()
    {
        var user = await _userManager.GetUserAsync(User);

        if (user == null)
        {
            return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        }

        try
        {
            var form = await Request.ReadFormAsync();
            var picturePath = await ImageHelper.UploadProfilePicture(form.Files.FirstOrDefault(), user.UserName,
                _hostingEnvironment.WebRootPath);

            if (string.IsNullOrEmpty(picturePath))
            {
                user.ProfilePictureUrl = Path.Combine(StockImagesBlobRelativePath, "stock-profile-img" + ".png");
            }
            else
            {
                BlobContainerClient blobProfilePictures =
                    _blobServiceClient.GetBlobContainerClient(ProfileImagesContainerName);

                await UploadFromFileAsync(blobProfilePictures, picturePath);
                user.ProfilePictureUrl = Path.Combine(ProfileImagesBlobRelativePath, user.UserName.ToLower() + ".jpg");

                ImageHelper.SynchronizeProfileImages(_hostingEnvironment.WebRootPath, user.UserName.ToLower());
            }

            await _userManager.UpdateAsync(user);
        }
        catch
        {
            return BadRequest();
        }

        return RedirectToAction("ProfileDisplay", "AccountManagement");
    }

    [HttpGet]
    public async Task<IActionResult> PasswordChange()
    {
        PasswordChangeModel model = new PasswordChangeModel();

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> PasswordChange(PasswordChangeModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var user = await _userManager.GetUserAsync(User);

        if (user == null)
        {
            return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        }

        var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

        if (!changePasswordResult.Succeeded)
        {
            foreach (var error in changePasswordResult.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(model);
        }

        await _signInManager.RefreshSignInAsync(user);
        StatusMessage = "Your password has been changed.";

        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public async Task<IActionResult> EmailChange()
    {
        var currentUser = await _userManager.GetUserAsync(User);

        if (currentUser == null)
        {
            return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");

        }

        var email = await _userManager.GetEmailAsync(currentUser);

        EmailChangeModel model = new EmailChangeModel()
        {
            NewEmail = email
        };

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EmailChange(EmailChangeModel model)
    {
        var user = await _userManager.GetUserAsync(User);

        if (user == null)
        {
            return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        }

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var changeEmailResult = await _userManager.SetEmailAsync(user, model.NewEmail);

        if (!changeEmailResult.Succeeded)
        {
            foreach (var error in changeEmailResult.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(model);
        }

        await _signInManager.RefreshSignInAsync(user);
        StatusMessage = "Your email has been changed.";

        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public async Task<IActionResult> PhoneNumberChange()
    {
        var currentUser = await _userManager.GetUserAsync(User);

        if (currentUser == null)
        {
            return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        }

        var phoneNumber = await _userManager.GetPhoneNumberAsync(currentUser);

        PhoneNumberChangeModel model = new PhoneNumberChangeModel
        {
            CurrentPhoneNumber = phoneNumber
        };

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> PhoneNumberChange(PhoneNumberChangeModel model)
    {
        var user = await _userManager.GetUserAsync(User);

        if (user == null)
        {
            return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        }

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

        if (!string.IsNullOrWhiteSpace(model.NewPhoneNumber))
        {
            if (phoneNumber != null)
            {
                var removePhoneNumberResult = await _userManager.SetPhoneNumberAsync(user, null);

                if (!removePhoneNumberResult.Succeeded)
                {
                    foreach (var error in removePhoneNumberResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }

                    return View(model);
                }
            }

            var changePhoneNumberResult = await _userManager.SetPhoneNumberAsync(user, model.NewPhoneNumber);

            if (!changePhoneNumberResult.Succeeded)
            {
                foreach (var error in changePhoneNumberResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return View(model);
            }
        }
        else
        {
            if (phoneNumber != null)
            {
                var removePhoneNumberResult = await _userManager.SetPhoneNumberAsync(user, null);

                if (!removePhoneNumberResult.Succeeded)
                {
                    foreach (var error in removePhoneNumberResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }

                    return View(model);
                }
            }
        }

        await _signInManager.RefreshSignInAsync(user);
        StatusMessage = "Your phone number has been changed.";

        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public async Task<IActionResult> DownloadPersonalData()
    {
        var user = await _userManager.GetUserAsync(User);

        if (user == null)
        {
            return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        }

        var personalData = new Dictionary<string, string>();
        var personalDataProps = typeof(ApplicationUser).GetProperties()
            .Where(prop => Attribute.IsDefined(prop, typeof(PersonalDataAttribute)));

        foreach (var p in personalDataProps)
        {
            var propValue = p.GetValue(user);

            if (propValue != null)
            {
                personalData.Add(p.Name, propValue.ToString());
            }
            else
            {
                personalData.Add(p.Name, "null");
            }
        }

        var logins = await _userManager.GetLoginsAsync(user);

        foreach (var l in logins)
        {
            personalData.Add($"{l.LoginProvider} external login provider key", l.ProviderKey);
        }

        personalData.Add($"Authenticator Key", await _userManager.GetAuthenticatorKeyAsync(user));

        var json = JsonConvert.SerializeObject(personalData, Formatting.Indented);
        var jsonBytes = Encoding.Unicode.GetBytes(json);

        var fileName = "PersonalData.json";

        return File(jsonBytes, "application/json; charset=utf-16", fileName);
    }

    [HttpGet]
    public IActionResult DeletePersonalData()
    {
        var model = new DeletePersonalDataModel();

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeletePersonalData(DeletePersonalDataModel model)
    {
        var user = await _userManager.GetUserAsync(User);

        if (user == null)
        {
            return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        }

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        if (model.Confirmation != "DELETE")
        {
            ModelState.AddModelError(string.Empty, "Confirmation text did not match 'DELETE'.");
            return View(model);
        }

        await AnonymizeAndDeleteUser(user);

        var updateResult = await _userManager.UpdateAsync(user);

        if (!updateResult.Succeeded)
        {
            foreach (var error in updateResult.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(model);
        }

        await _signInManager.SignOutAsync();

        return RedirectToAction("Index", "Home");
    }

    private async Task AnonymizeAndDeleteUser(ApplicationUser user)
    {
        var anonymizedUserName = "Anonymized_" + Guid.NewGuid().ToString();

        user.OriginalUsername = user.UserName;

        await _userManager.SetUserNameAsync(user, anonymizedUserName);
        await _userManager.SetEmailAsync(user, null);
        await _userManager.SetPhoneNumberAsync(user, null);
        await _userManager.UpdateSecurityStampAsync(user);

        user.ProfilePictureUrl = null;
        user.PasswordHash = null;

        user.IsDeleted = true;

        await _userManager.UpdateAsync(user);
    }
}