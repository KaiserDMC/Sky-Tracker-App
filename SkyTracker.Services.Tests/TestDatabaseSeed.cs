namespace SkyTracker.Services.Tests;

using Microsoft.AspNetCore.Identity;

using SkyTracker.Data;
using SkyTracker.Data.Models;

using static Common.UserRoleNames;
using static Common.GeneralApplicationContants;

public class TestDatabaseSeed
{
    private UserManager<ApplicationUser> _userManager;

    public TestDatabaseSeed(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public void SeedDatabase(SkyTrackerDbContext dbContext)
    {
        SeedAdministrator(DevAndTestingAdminEmail).GetAwaiter().GetResult();
        SeedModerator(DevAndTestingModeratorEmail).GetAwaiter().GetResult();
    }

    public async Task SeedAdministrator(string email)
    {
        ApplicationUser adminUser = await _userManager.FindByEmailAsync(email);

        if (adminUser != null && !await _userManager.IsInRoleAsync(adminUser, AdminRole))
        {
            var newSecurityStamp = await _userManager.UpdateSecurityStampAsync(adminUser);

            await _userManager.AddToRoleAsync(adminUser, AdminRole);
        }
    }

    public async Task SeedModerator(string email)
    {
        ApplicationUser moderatorUser = await _userManager.FindByEmailAsync(email);

        if (moderatorUser != null && !await _userManager.IsInRoleAsync(moderatorUser, ModeratorRole))
        {
            var newSecurityStamp = await _userManager.UpdateSecurityStampAsync(moderatorUser);

            await _userManager.AddToRoleAsync(moderatorUser, ModeratorRole);
        }
    }
}