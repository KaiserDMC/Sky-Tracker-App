namespace SkyTracker.Services.Data;

using System.Security.Claims;

using Interfaces;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using SkyTracker.Data;
using SkyTracker.Data.Models;

using Web.Infrastructure.Extensions;
using Web.ViewModels.User;

using static Common.UserRoleNames;

public class UserManagementService : IUserManagementService
{
    private readonly SkyTrackerDbContext _dbContext;
    private readonly UserManager<ApplicationUser> _userManager;

    public UserManagementService(SkyTrackerDbContext dbContext, UserManager<ApplicationUser> userManager)
    {
        _dbContext = dbContext;
        _userManager = userManager;
    }

    public async Task<IEnumerable<UserViewModel>> GetCommonUsersAsync()
    {
        var users = await _dbContext.Users
            .Where(u => u.IsDeleted == false)
            .Where(u => u.LockoutEnd.HasValue == false)
            .OrderBy(u => u.UserName)
            .ToListAsync();

        var nonAdminUsersViewModels = new List<UserViewModel>();

        foreach (var user in users)
        {
            if (!await IsUserInRoleAsync(user, AdminRole))
            {
                nonAdminUsersViewModels.Add(new UserViewModel()
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber
                });
            }
        }

        return nonAdminUsersViewModels;
    }

    public async Task<IEnumerable<UserViewModel>> GetAdminUsersAsync(HttpContext httpContext)
    {
        var currentUserId = httpContext.User.GetId();

        var users = await _dbContext.Users
            .Where(u => u.IsDeleted == false)
            .Where(u => u.Id.ToString() != currentUserId)
            .OrderBy(u => u.UserName)
            .ToListAsync();

        var AdminUsersViewModels = new List<UserViewModel>();

        foreach (var user in users)
        {
            if (await IsUserInRoleAsync(user, AdminRole))
            {
                AdminUsersViewModels.Add(new UserViewModel()
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber
                });
            }
        }

        return AdminUsersViewModels;
    }

    public async Task<IEnumerable<UserViewModel>> GetLockedUsersAsync()
    {
        var users = await _dbContext.Users
            .Where(u => u.IsDeleted == false)
            .Where(u => u.LockoutEnd.HasValue == true)
            .OrderBy(u => u.UserName)
            .ToListAsync();

        var lockedUsersViewModels = new List<UserViewModel>();

        foreach (var user in users)
        {
            lockedUsersViewModels.Add(new UserViewModel()
            {
                Id = user.Id,
                Username = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber
            });
        }

        return lockedUsersViewModels;
    }


    private async Task<bool> IsUserInRoleAsync(ApplicationUser user, string role)
    {
        return await _userManager.IsInRoleAsync(user, role);
    }
}