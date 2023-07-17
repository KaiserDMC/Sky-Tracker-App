namespace SkyTracker.Services.Data.Interfaces;

using Microsoft.AspNetCore.Http;

using Web.ViewModels.User;

public interface IUserManagementService
{
    Task<IEnumerable<UserViewModel>> GetCommonUsersAsync();

    Task<IEnumerable<UserViewModel>> GetAdminUsersAsync(HttpContext httpContext);

    Task<IEnumerable<UserViewModel>> GetLockedUsersAsync();
}