namespace SkyTracker.Controllers.Tests;

using System.Text.Json;

using Data.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Moq;

using SkyTracker.Web.Areas.Admin.Controllers;
using SkyTracker.Web.Areas.Admin.Services.Interfaces;

/// <summary>
/// User Management Controller Unit Tests using Moq
/// </summary>

public class UserManagementControllerTests
{
    private UserManagementController _userManagementController;
    private Mock<IUserManagementService> _mockUserManagementService;
    private Mock<UserManager<ApplicationUser>> _mockUserManager;

    [SetUp]
    public void Setup()
    {
        _mockUserManagementService = new Mock<IUserManagementService>();
        _mockUserManager = new Mock<UserManager<ApplicationUser>>(Mock.Of<IUserStore<ApplicationUser>>(), null, null, null, null, null, null, null, null);

        _userManagementController = new UserManagementController(_mockUserManagementService.Object, _mockUserManager.Object);
    }

    private List<ApplicationUser> GetSampleUsers()
    {
        var users = new List<ApplicationUser>
        {
            new ApplicationUser { Id = Guid.NewGuid(), UserName = "user1" },
            new ApplicationUser { Id = Guid.NewGuid(), UserName = "user2"}
        };

        return users;
    }

    private static string ToJsonString(object obj)
    {
        return JsonSerializer.Serialize(obj, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        });
    }

    /*
        Tests for UsersPartial, ModeratorListPartial and LockedUsersPartial are omitted because their main functionality was tested in the UserManagementServiceTests.
        The untested part is the Pagination, but that uses a third-party library called X.PagedList.
    */

    [Test]
    public async Task Promote_ValidUserIds_SuccessfulPromotion()
    {
        var users = GetSampleUsers();

        _mockUserManager.Setup(u => u.FindByIdAsync("user1")).ReturnsAsync(users.Find(u => u.UserName == "user1"));
        _mockUserManager.Setup(u => u.FindByIdAsync("user2")).ReturnsAsync(users.Find(u => u.UserName == "user2"));

        var result = await _userManagementController.Promote(new[] { "user1", "user2" });

        Assert.IsInstanceOf<JsonResult>(result);
        var jsonResult = (JsonResult)result;
        dynamic data = jsonResult.Value;

        var expectedJson = ToJsonString(new { success = true, message = "Selected users were promoted to Moderators successfully!" });

        var actualJson = ToJsonString(data);

        Assert.AreEqual(expectedJson, actualJson);
    }

    [Test]
    public async Task Promote_UserNotFound_ReturnsSuccessForOtherUsers()
    {
        var users = GetSampleUsers();

        _mockUserManager.Setup(u => u.FindByIdAsync("user")).ReturnsAsync(users.Find(u => u.UserName == "user1"));
        _mockUserManager.Setup(u => u.FindByIdAsync("notfound")).ReturnsAsync((ApplicationUser)null);

        var result = await _userManagementController.Promote(new[] { "user", "notfound" });

        Assert.IsInstanceOf<JsonResult>(result);
        var jsonResult = (JsonResult)result;
        dynamic data = jsonResult.Value;

        var expectedJson = ToJsonString(new { success = true, message = "Selected users were promoted to Moderators successfully!" });

        var actualJson = ToJsonString(data);

        Assert.AreEqual(expectedJson, actualJson);
    }

    /*
        Non Existing User Ids and Not Selecting Ids logic is handled on the client side with JavaScript. This applies to Promote, Demote, Lockout and Unlock methods.
    */

    [Test]
    public async Task Demote_ValidUserIds_SuccessfulDemotion()
    {
        var users = GetSampleUsers();

        _mockUserManager.Setup(u => u.FindByIdAsync("user1")).ReturnsAsync(users.Find(u => u.UserName == "user1"));
        _mockUserManager.Setup(u => u.FindByIdAsync("user2")).ReturnsAsync(users.Find(u => u.UserName == "user2"));

        var result = await _userManagementController.Demote(new[] { "user1", "user2" });

        Assert.IsInstanceOf<JsonResult>(result);
        var jsonResult = (JsonResult)result;
        dynamic data = jsonResult.Value;

        var expectedJson = ToJsonString(new { success = true, message = "Selected users were demoted to Regular users successfully!" });

        var actualJson = ToJsonString(data);

        Assert.AreEqual(expectedJson, actualJson);
    }

    [Test]
    public async Task Demote_UserNotFound_ReturnsSuccessForOtherUsers()
    {
        var users = GetSampleUsers();

        _mockUserManager.Setup(u => u.FindByIdAsync("user")).ReturnsAsync(users.Find(u => u.UserName == "user1"));
        _mockUserManager.Setup(u => u.FindByIdAsync("notfound")).ReturnsAsync((ApplicationUser)null);

        var result = await _userManagementController.Demote(new[] { "user", "notfound" });

        Assert.IsInstanceOf<JsonResult>(result);
        var jsonResult = (JsonResult)result;
        dynamic data = jsonResult.Value;

        var expectedJson = ToJsonString(new { success = true, message = "Selected users were demoted to Regular users successfully!"});

        var actualJson = ToJsonString(data);

        Assert.AreEqual(expectedJson, actualJson);
    }

    [Test]
    public async Task Lockout_ValidUserIds_SuccessfulLockOut()
    {
        var users = GetSampleUsers();

        _mockUserManager.Setup(u => u.FindByIdAsync("user1")).ReturnsAsync(users.Find(u => u.UserName == "user1"));
        _mockUserManager.Setup(u => u.FindByIdAsync("user2")).ReturnsAsync(users.Find(u => u.UserName == "user2"));

        var result = await _userManagementController.Lockout(new[] { "user1", "user2" });

        Assert.IsInstanceOf<JsonResult>(result);
        var jsonResult = (JsonResult)result;
        dynamic data = jsonResult.Value;

        var expectedJson = ToJsonString(new { success = true, message =  "Selected users were banned successfully!" });

        var actualJson = ToJsonString(data);

        Assert.AreEqual(expectedJson, actualJson);
    }

    [Test]
    public async Task Lockout_UserNotFound_ReturnsSuccessForOtherUsers()
    {
        var users = GetSampleUsers();

        _mockUserManager.Setup(u => u.FindByIdAsync("user")).ReturnsAsync(users.Find(u => u.UserName == "user1"));
        _mockUserManager.Setup(u => u.FindByIdAsync("notfound")).ReturnsAsync((ApplicationUser)null);

        var result = await _userManagementController.Lockout(new[] { "user", "notfound" });

        Assert.IsInstanceOf<JsonResult>(result);
        var jsonResult = (JsonResult)result;
        dynamic data = jsonResult.Value;

        var expectedJson = ToJsonString(new { success = true, message =  "Selected users were banned successfully!" });

        var actualJson = ToJsonString(data);

        Assert.AreEqual(expectedJson, actualJson);
    }

    [Test]
    public async Task Unlock_ValidUserIds_SuccessfulUnlock()
    {
        var users = GetSampleUsers();

        _mockUserManager.Setup(u => u.FindByIdAsync("user1")).ReturnsAsync(users.Find(u => u.UserName == "user1"));
        _mockUserManager.Setup(u => u.FindByIdAsync("user2")).ReturnsAsync(users.Find(u => u.UserName == "user2"));

        var result = await _userManagementController.Unlock(new[] { "user1", "user2" });

        Assert.IsInstanceOf<JsonResult>(result);
        var jsonResult = (JsonResult)result;
        dynamic data = jsonResult.Value;

        var expectedJson = ToJsonString(new { success = true, message = "Selected users were released from jail successfully!" });

        var actualJson = ToJsonString(data);

        Assert.AreEqual(expectedJson, actualJson);
    }

    [Test]
    public async Task Unlock_UserNotFound_ReturnsSuccessForOtherUsers()
    {
        var users = GetSampleUsers();

        _mockUserManager.Setup(u => u.FindByIdAsync("user")).ReturnsAsync(users.Find(u => u.UserName == "user1"));
        _mockUserManager.Setup(u => u.FindByIdAsync("notfound")).ReturnsAsync((ApplicationUser)null);

        var result = await _userManagementController.Unlock(new[] { "user", "notfound" });

        Assert.IsInstanceOf<JsonResult>(result);
        var jsonResult = (JsonResult)result;
        dynamic data = jsonResult.Value;

        var expectedJson = ToJsonString(new { success = true, message = "Selected users were released from jail successfully!" });

        var actualJson = ToJsonString(data);

        Assert.AreEqual(expectedJson, actualJson);
    }
}