﻿using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

using ViewModels.User;
using Data.Models;
using static Common.UserRoleNames;
using Microsoft.AspNetCore.Authentication;

public class UserController : Controller
{
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUserStore<ApplicationUser> _userStore;

    public UserController(UserManager<ApplicationUser> userManager,
        IUserStore<ApplicationUser> userStore,
        SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _userStore = userStore;
        _signInManager = signInManager;
    }

    public string ReturnUrl { get; set; }

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

        var user = new ApplicationUser()
        {
            UserName = model.UserName,
            Email = model.Email
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

        var user = await _userManager.FindByNameAsync(model.UserName);

        if (user != null)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, lockoutOnFailure: false);

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