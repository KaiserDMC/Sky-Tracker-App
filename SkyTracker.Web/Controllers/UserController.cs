namespace SkyTracker.Web.Controllers;

using System.Threading;

using Azure.Storage.Blobs;

using Data.Models;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using ViewModels.User;

using static Common.GeneralApplicationContants;
using static Common.UserRoleNames;
using static Configuration.DownloadBlob;

[AllowAnonymous]
public class UserController : Controller
{
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUserStore<ApplicationUser> _userStore;
    private readonly BlobServiceClient _blobServiceClient;
    private readonly IWebHostEnvironment _hostingEnvironment;

    public UserController(UserManager<ApplicationUser> userManager,
        IUserStore<ApplicationUser> userStore,
        SignInManager<ApplicationUser> signInManager, BlobServiceClient blobServiceClient, IWebHostEnvironment hostingEnvironment)
    {
        _userManager = userManager;
        _userStore = userStore;
        _signInManager = signInManager;
        _blobServiceClient = blobServiceClient;
        _hostingEnvironment = hostingEnvironment;
    }

    public string? ReturnUrl { get; set; }

    [TempData]
    public string ErrorMessage { get; set; }


    [HttpGet]
    public async Task<IActionResult> Register(string returnUrl = null)
    {
        if (User?.Identity?.IsAuthenticated ?? false)
        {
            Response.Redirect("../../Home/Index");
        }

        RegisterViewModel model = new RegisterViewModel();

        ReturnUrl = returnUrl;

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
    {
        returnUrl ??= Url.Content("~/");

        ModelState.Remove("returnUrl");

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        BlobContainerClient blobUser = _blobServiceClient.GetBlobContainerClient(StockImagesContainerName);
        BlobClient blob = blobUser.GetBlobClient("stock-profile-img" + ".png");

        string localPath = Path.Combine(_hostingEnvironment.WebRootPath, StockImagesBlobRelativePath, "stock-profile-img" + ".png");

        if (await blob.ExistsAsync())
        {
            await DownloadBlobToFileAsync(blob, localPath);

            localPath = Path.Combine(StockImagesBlobRelativePath, "stock-profile-img" + ".png");
        }

        var user = new ApplicationUser()
        {
            UserName = model.UserName,
            Email = model.Email,
            ProfilePictureUrl = localPath
        };

        var result = await _userManager.CreateAsync(user, model.Password);

        await _userStore.SetUserNameAsync(user, user.UserName, CancellationToken.None);

        if (result.Succeeded)
        {
            await _userManager.AddToRoleAsync(user, UserRole);
            await _signInManager.SignInAsync(user, isPersistent: false);
            return LocalRedirect(returnUrl);
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }

        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> Login(string returnUrl = null)
    {
        if (User?.Identity?.IsAuthenticated ?? false)
        {
            Response.Redirect("../../Home/Index");
        }

        if (!string.IsNullOrEmpty(ErrorMessage))
        {
            ModelState.AddModelError(string.Empty, ErrorMessage);
        }

        returnUrl ??= Url.Content("~/");

        LoginViewModel model = new LoginViewModel();

        await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

        ReturnUrl = returnUrl;

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
    {
        returnUrl ??= Url.Content("~/");

        ModelState.Remove("returnUrl");

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var user = await _userManager.FindByNameAsync(model.Username);

        if (user != null)
        {
            if (user.IsDeleted)
            {
                ModelState.AddModelError(string.Empty, "Your account has been deleted. Please contact support for assistance.");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");

                return View(model);
            }

        }

        ModelState.AddModelError(string.Empty, "Invalid login attempt.");

        return View(model);
    }

    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();

        return RedirectToAction(nameof(HomeController.Index), "Home");
    }
}