namespace SkyTracker.Web.Areas.Admin.Services.Interfaces;

using ViewModels.User;

public interface IUserManagementService
{
    Task<IEnumerable<UserViewModel>> GetCommonUsersAsync();

    Task<IEnumerable<UserViewModel>> GetModeratorUsersAsync();

    Task<IEnumerable<UserViewModel>> GetLockedUsersAsync();
}