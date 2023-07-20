namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Data.Models;
using SkyTracker.Services.Data.Interfaces;
using X.PagedList;

using static Common.GeneralApplicationContants;
using static Common.UserRoleNames;

[Authorize(Roles = "Admin")]
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

        int pageNumber = (page ?? 1);

        var pagedData = users.ToPagedList(pageNumber, pageSize);

        return PartialView("_UsersPartial", pagedData);
    }

    [HttpGet]
    public async Task<IActionResult> ModeratorListPartial(int? page)
    {
        var users = await _userManagementService.GetModeratorUsersAsync();

        int pageSize = DefaultAdminListEntitiesPerPage;

        int pageNumber = (page ?? 1);

        var pagedData = users.ToPagedList(pageNumber, pageSize);

        return PartialView("_ModeratorListPartial", pagedData);
    }

    [HttpPost]
    public async Task<IActionResult> Promote(string[] userIds)
    {
        foreach (var userId in userIds)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user != null)
            {
                await _userManager.AddToRoleAsync(user, ModeratorRole);
            }
        }

        return Json(new { success = true });
    }

    [HttpPost]
    public async Task<IActionResult> Demote(string[] userIds)
    {
        foreach (var userId in userIds)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user != null)
            {
                await _userManager.RemoveFromRoleAsync(user, ModeratorRole);
            }
        }

        return Json(new { success = true });
    }

    [HttpPost]
    public async Task<IActionResult> Lockout(string[] userIds)
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

        return Json(new { success = true });
    }

    [HttpGet]
    public async Task<IActionResult> LockedUsersPartial(int? page)
    {
        var users = await _userManagementService.GetLockedUsersAsync();

        int pageSize = DefaultAdminListEntitiesPerPage;

        int pageNumber = (page ?? 1);

        var pagedData = users.ToPagedList(pageNumber, pageSize);

        return PartialView("_LockedUsersPartial", pagedData);
    }

    [HttpPost]
    public async Task<IActionResult> Unlock(string[] userIds)
    {
        foreach (var userId in userIds)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user != null)
            {
                await _userManager.SetLockoutEndDateAsync(user, null);
            }
        }

        return Json(new { success = true });
    }
}