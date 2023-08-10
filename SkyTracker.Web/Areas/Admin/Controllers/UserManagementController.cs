namespace SkyTracker.Web.Areas.Admin.Controllers;

using Data.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Services.Interfaces;

using SkyTracker.Data.Migrations;

using X.PagedList;

using static Common.GeneralApplicationContants;
using static Common.UserRoleNames;

/// <summary>
/// User Management Controller. Give the ability to Admin to manage users.
/// </summary>

[Area("Admin")]
[Authorize(Roles = "Admin")]
[AutoValidateAntiforgeryToken]
public class UserManagementController : Controller
{
    private readonly IUserManagementService _userManagementService;
    private readonly UserManager<ApplicationUser> _userManager;

    public UserManagementController(IUserManagementService userManagementService, UserManager<ApplicationUser> userManager)
    {
        _userManagementService = userManagementService;
        _userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> UsersPartial(int? page)
    {
        var users = await _userManagementService.GetCommonUsersAsync();

        int pageSize = DefaultAdminListEntitiesPerPage;

        int pageNumber = page ?? 1;

        var pagedData = users.ToPagedList(pageNumber, pageSize);

        return PartialView("_UsersPartial", pagedData);
    }

    [HttpGet]
    public async Task<IActionResult> ModeratorListPartial(int? page)
    {
        var users = await _userManagementService.GetModeratorUsersAsync();

        int pageSize = DefaultAdminListEntitiesPerPage;

        int pageNumber = page ?? 1;

        var pagedData = users.ToPagedList(pageNumber, pageSize);
        return PartialView("_ModeratorListPartial", pagedData);
    }

    [HttpPost]
    public async Task<IActionResult> Promote(string[] userIds)
    {
        try
        {
            foreach (var userId in userIds)
            {
                var user = await _userManager.FindByIdAsync(userId);

                if (user != null)
                {
                    await _userManager.AddToRoleAsync(user, ModeratorRole);
                }
            }

            return Json(new { success = true, message = "Selected users were promoted to Moderators successfully!" });
        }
        catch
        {
           return Json(new { success = false, message = "Error: Something went wrong and users were not promoted to Moderators!" });
        }
    }

    [HttpPost]
    public async Task<IActionResult> Demote(string[] userIds)
    {
        try
        {
            foreach (var userId in userIds)
            {
                var user = await _userManager.FindByIdAsync(userId);

                if (user != null)
                {
                    await _userManager.RemoveFromRoleAsync(user, ModeratorRole);
                }
            }

            return Json(new { success = true, message = "Selected users were demoted to Regular users successfully!" });
        }
        catch
        {
            return Json(new { success = false, message = "Error: Something went wrong and users were not demoted to Regular users!" });
        }
    }

    [HttpPost]
    public async Task<IActionResult> Lockout(string[] userIds)
    {
        try
        {
            foreach (var userId in userIds)
            {
                var user = await _userManager.FindByIdAsync(userId);

                if (user != null)
                {
                    user.LockoutEnabled = true;
                    await _userManager.SetLockoutEndDateAsync(user, DateTime.UtcNow.AddYears(100));
                }
            }

            return Json(new { success = true, message =  "Selected users were banned successfully!"});
        }
        catch
        {
            return Json(new { success = false, message = "Error: Something went wrong and users were not banned!" });
        }
    }

    [HttpGet]
    public async Task<IActionResult> LockedUsersPartial(int? page)
    {
        var users = await _userManagementService.GetLockedUsersAsync();

        int pageSize = DefaultAdminListEntitiesPerPage;

        int pageNumber = page ?? 1;

        var pagedData = users.ToPagedList(pageNumber, pageSize);

        return PartialView("_LockedUsersPartial", pagedData);
    }

    [HttpPost]
    public async Task<IActionResult> Unlock(string[] userIds)
    {
        try
        {
            foreach (var userId in userIds)
            {
                var user = await _userManager.FindByIdAsync(userId);

                if (user != null)
                {
                    await _userManager.SetLockoutEndDateAsync(user, null);
                }
            }

            return Json(new { success = true, message = "Selected users were released from jail successfully!" });
        }
        catch
        {
            return Json(new { success = false, message = "Error: Something went wrong and users were not released from jail!" });
        }
    }
}