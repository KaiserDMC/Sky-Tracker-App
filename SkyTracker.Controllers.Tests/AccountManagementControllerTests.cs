using System.Security.Claims;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Moq;

using SkyTracker.Web.ViewModels.AccountManagement;

namespace SkyTracker.Controllers.Tests;

using Azure.Storage.Blobs;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

using Data.Models;
using SkyTracker.Web.Controllers;

public class AccountManagementControllerTests
{
    private AccountManagementController _accountManagementController;
    private Mock<UserManager<ApplicationUser>> _mockUserManager;
    private PasswordChangeModel _validPasswordChangeModel;
    private EmailChangeModel _validEmailChangeModel;

    [SetUp]
    public void Setup()
    {
        _mockUserManager = new Mock<UserManager<ApplicationUser>>(Mock.Of<IUserStore<ApplicationUser>>(), null, null, null, null, null, null, null, null);

        var mockHttpContext = new DefaultHttpContext();
        mockHttpContext.User = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
        {
            new Claim(ClaimTypes.NameIdentifier, "testUserId")
        }));

        _accountManagementController = new AccountManagementController(_mockUserManager.Object, null, null, null)
        {
            ControllerContext = new ControllerContext()
            {
                HttpContext = mockHttpContext
            }
        };

        _validPasswordChangeModel = new PasswordChangeModel
        {
            OldPassword = "oldPassword",
            NewPassword = "newPassword",
            ConfirmPassword = "newPassword"
        };

        _validEmailChangeModel = new EmailChangeModel
        {
            NewEmail = "newemail@example.com"
        };
    }

    [Test]
    public async Task ProfileDisplay_ShouldWork_ReturnsViewWithModel()
    {
        var user = new ApplicationUser
        {
            UserName = "testuser",
            Email = "test@example.com",
            PhoneNumber = "1234567890",
            ProfilePictureUrl = "path/to/profile_picture.jpg"
        };

        _mockUserManager.Setup(manager => manager.GetUserAsync(It.IsAny<ClaimsPrincipal>()))
            .ReturnsAsync(user);

        var result = await _accountManagementController.ProfileDisplay();

        Assert.IsInstanceOf<ViewResult>(result);
        var viewResult = result as ViewResult;
        Assert.IsInstanceOf<ProfileDisplayModel>(viewResult.Model);

        var model = viewResult.Model as ProfileDisplayModel;
        Assert.AreEqual(user.Id.ToString(), model.UserId);
        Assert.AreEqual("testuser", model.Username);
        Assert.AreEqual("test@example.com", model.Email);
        Assert.AreEqual("1234567890", model.PhoneNumber);
        Assert.AreEqual("path/to/profile_picture.jpg", model.ProfilePictureUrl);
    }

    [Test]
    public async Task ProfileDisplay_ShouldThrow_NonExistingUser()
    {
        _mockUserManager.Setup(manager => manager.GetUserAsync(It.IsAny<ClaimsPrincipal>()))
            .ReturnsAsync((ApplicationUser)null);

        var result = await _accountManagementController.ProfileDisplay();

        Assert.IsInstanceOf<NotFoundObjectResult>(result);
        var notFoundResult = result as NotFoundObjectResult;
        Assert.AreEqual($"Unable to load user with ID ''.", notFoundResult.Value);
    }

    //
    // Picture Upload not tested because it is handled by Azure Blob Storage
    //

    [Test]
    public async Task PasswordChange_Get_ReturnsViewWithModel()
    {
        // Arrange

        // Act
        var result = await _accountManagementController.PasswordChange();

        // Assert
        Assert.IsInstanceOf<ViewResult>(result);
        var viewResult = result as ViewResult;
        Assert.IsInstanceOf<PasswordChangeModel>(viewResult.Model);
    }







}