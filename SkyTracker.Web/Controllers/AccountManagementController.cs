namespace SkyTracker.Web.Controllers;

using System.Text;

using Data.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using ViewModels.AccountManagement;

[Authorize]
public class AccountManagementController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountManagementController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [TempData]
    public string StatusMessage { get; set; }


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

        user.IsDeleted = true;

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
}