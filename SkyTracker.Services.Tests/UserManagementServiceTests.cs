namespace SkyTracker.Services.Tests;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Moq;

using SkyTracker.Data;
using SkyTracker.Data.Models;
using SkyTracker.Web.Areas.Admin.Services;
using SkyTracker.Web.Areas.Admin.Services.Interfaces;

using static Common.GeneralApplicationContants;
using static Common.UserRoleNames;
using static TestDatabaseSeed;

public class UserManagementServiceTests
{
    private Mock<UserManager<ApplicationUser>> _userManagerMock;
    private SkyTrackerDbContext _dbContext;

    private IUserManagementService _userManagementService;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<SkyTrackerDbContext>()
            .UseInMemoryDatabase(databaseName: "SkyTrackerTestDb")
            .Options;

        this._dbContext = new SkyTrackerDbContext(options);

        this._dbContext.Database.EnsureCreated();

        SeedDatabase(this._dbContext);
        _userManagerMock = MockUserManager<ApplicationUser>();

        this._userManagementService = new UserManagementService(this._dbContext, _userManagerMock.Object);
    }

    [TearDown]
    public void TearDown()
    {
        _dbContext.Database.EnsureDeleted();
    }

    private Mock<UserManager<TUser>> MockUserManager<TUser>() where TUser : class
    {
        var userStoreMock = new Mock<IUserStore<TUser>>();
        return new Mock<UserManager<TUser>>(userStoreMock.Object, null, null, null, null, null, null, null, null);
    }

    [Test]
    public async Task GetCommonUsersAsync_ShouldWork_ReturnCommonUsers()
    {
        var users = await this._userManagementService.GetCommonUsersAsync();

        Assert.AreEqual(2, users.Count());
    }

    [Test]
    public async Task GetCommonUsersAsync_ShouldWork_ReturnEmptyCommonCollection()
    {
        var userManagerMock = MockUserManager<ApplicationUser>();

        var mod = _dbContext.Users.FirstOrDefault(u => u.Email == DevAndTestingModeratorEmail);

        userManagerMock.Setup(m => m.IsInRoleAsync(mod, ModeratorRole)).ReturnsAsync(true);

        var admin = _dbContext.Users.FirstOrDefault(u => u.Email == DevAndTestingAdminEmail);

        userManagerMock.Setup(m => m.IsInRoleAsync(admin, AdminRole)).ReturnsAsync(true);

        var userManagementService = new UserManagementService(_dbContext, userManagerMock.Object);

        var users = await userManagementService.GetCommonUsersAsync();

        Assert.AreEqual(0, users.Count());
    }

    [Test]
    public async Task GetModeratorUsersAsync_ShouldWork_ReturnModeratorUsers()
    {
        var userManagerMock = MockUserManager<ApplicationUser>();

        var mod = _dbContext.Users.FirstOrDefault(u => u.Email == DevAndTestingModeratorEmail);

        userManagerMock.Setup(m => m.IsInRoleAsync(mod, ModeratorRole)).ReturnsAsync(true);

        var userManagementService = new UserManagementService(_dbContext, userManagerMock.Object);

        var users = await userManagementService.GetModeratorUsersAsync();

        Assert.AreEqual(1, users.Count());
    }

    [Test]
    public async Task GetModeratorUsersAsync_ShouldWork_ReturnEmptyModeratorCollection()
    {
        var users = await this._userManagementService.GetModeratorUsersAsync();

        Assert.AreEqual(0, users.Count());
    }

    [Test]
    public async Task GetLockedUsersAsync_ShouldWork_ReturnAllLockedUsers()
    {
        var userManagerMock = MockUserManager<ApplicationUser>();
        var modLock = _dbContext.Users.FirstOrDefault(u => u.Email == DevAndTestingModeratorEmail);

        modLock.LockoutEnd = DateTime.UtcNow.AddDays(1);

        await _dbContext.SaveChangesAsync();

        userManagerMock.Setup(m => m.FindByIdAsync(modLock.Id.ToString())).ReturnsAsync(modLock);

        var userManagementService = new UserManagementService(_dbContext, userManagerMock.Object);

        var users = await userManagementService.GetLockedUsersAsync();

        Assert.AreEqual(1, users.Count());
    }

    [Test]
    public async Task GetLockedUsersAsync_ShouldWork_ReturnEmptyLockedCollection()
    {
        var users = await this._userManagementService.GetLockedUsersAsync();

        Assert.AreEqual(0, users.Count());
    }
}