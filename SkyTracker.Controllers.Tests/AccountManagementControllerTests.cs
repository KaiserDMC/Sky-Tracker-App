namespace SkyTracker.Controllers.Tests;

using System.Security.Claims;

using Data.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

using Moq;

using SkyTracker.Web.Controllers;

using Web.ViewModels.AccountManagement;

/// <summary>
/// Account Management Controller Unit Tests using Moq
/// </summary>

public class AccountManagementControllerTests
{
    private AccountManagementController _accountManagementController;
    private Mock<UserManager<ApplicationUser>> _mockUserManager;
    private Mock<SignInManager<ApplicationUser>> _mockSignInManager;
    private PasswordChangeModel _validPasswordChangeModel;

    [SetUp]
    public void Setup()
    {
        _mockUserManager = new Mock<UserManager<ApplicationUser>>(
            Mock.Of<IUserStore<ApplicationUser>>(), null, null, null, null, null, null, null, null);

        _mockSignInManager = new Mock<SignInManager<ApplicationUser>>(
            _mockUserManager.Object, Mock.Of<IHttpContextAccessor>(), Mock.Of<IUserClaimsPrincipalFactory<ApplicationUser>>(), null, null, null, null);

        _accountManagementController = new AccountManagementController(
            _mockUserManager.Object, _mockSignInManager.Object, null, null)
        {
            ControllerContext = new ControllerContext()
            {
                HttpContext = GetMockHttpContext()
            }
        };

        _validPasswordChangeModel = new PasswordChangeModel
        {
            OldPassword = "oldPassword",
            NewPassword = "newPassword",
            ConfirmPassword = "newPassword"
        };
    }

    private static HttpContext GetMockHttpContext()
    {
        var context = new DefaultHttpContext();
        context.User = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
        {
            new Claim(ClaimTypes.NameIdentifier, "f47ac10b-58cc-4372-a567-0e02b2c3d479")
        }));

        return context;
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

    /*
        Picture Upload not tested because it is handled by Azure Blob Storage
    */

    [Test]
    public async Task PasswordChange_Get_ReturnsViewWithModel()
    {
        var result = await _accountManagementController.PasswordChange();

        Assert.IsInstanceOf<ViewResult>(result);
        var viewResult = result as ViewResult;
        Assert.IsInstanceOf<PasswordChangeModel>(viewResult.Model);
    }

    [Test]
    public async Task PasswordChange_ValidModel_ReturnsRedirectToAction()
    {
        var mockHttpContext = GetMockHttpContext();
        _accountManagementController.ControllerContext = new ControllerContext()
        {
            HttpContext = mockHttpContext
        };

        string userId = mockHttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

        var defaultUser = new ApplicationUser { Id = Guid.Parse(userId) };

        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>()))
            .ReturnsAsync(defaultUser);

        _mockUserManager.Setup(u => u.ChangePasswordAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>(), It.IsAny<string>()))
            .ReturnsAsync(IdentityResult.Success);

        var tempData = new TempDataDictionary(_accountManagementController.ControllerContext.HttpContext, Mock.Of<ITempDataProvider>());
        _accountManagementController.TempData = tempData;

        var result = await _accountManagementController.PasswordChange(_validPasswordChangeModel);

        Assert.IsInstanceOf<RedirectToActionResult>(result);

        var redirectResult = (RedirectToActionResult)result;

        Assert.AreEqual("Index", redirectResult.ActionName);
        Assert.AreEqual("Home", redirectResult.ControllerName);

        Assert.AreEqual("Your password has been changed.", _accountManagementController.StatusMessage);
    }

    [Test]
    public async Task PasswordChange_ShouldThrow_ReturnsNotFoundUserNull()
    {
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>()))
            .ReturnsAsync((ApplicationUser)null);

        var result = await _accountManagementController.PasswordChange(_validPasswordChangeModel);

        Assert.IsInstanceOf<NotFoundObjectResult>(result);
        var notFoundResult = (NotFoundObjectResult)result;

        Assert.AreEqual($"Unable to load user with ID ''.", notFoundResult.Value);
    }

    [Test]
    public async Task EmailChange_Get_UserFound_ReturnsViewWithModel()
    {
        var user = new ApplicationUser();
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);

        var result = await _accountManagementController.EmailChange();

        Assert.IsInstanceOf<ViewResult>(result);

        var viewResult = (ViewResult)result;
        Assert.IsInstanceOf<EmailChangeModel>(viewResult.Model);
    }

    [Test]
    public async Task EmailChange_Get_UserNotFound_ReturnsNotFound()
    {
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync((ApplicationUser)null);

        var result = await _accountManagementController.EmailChange();

        Assert.IsInstanceOf<NotFoundObjectResult>(result);
    }

    [Test]
    public async Task EmailChange_Post_UserFound_EmailChangeSuccess_ReturnsRedirectToAction()
    {
        var user = new ApplicationUser();
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);
        _mockUserManager.Setup(u => u.SetEmailAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success);

        var tempData = new TempDataDictionary(_accountManagementController.ControllerContext.HttpContext, Mock.Of<ITempDataProvider>());
        _accountManagementController.TempData = tempData;

        var result = await _accountManagementController.EmailChange(new EmailChangeModel());

        Assert.IsInstanceOf<RedirectToActionResult>(result);
        var redirectResult = (RedirectToActionResult)result;

        Assert.AreEqual("Index", redirectResult.ActionName);
        Assert.AreEqual("Home", redirectResult.ControllerName);

        Assert.AreEqual("Your email has been changed.", _accountManagementController.StatusMessage);
    }

    [Test]
    public async Task EmailChange_Post_UserFound_EmailChangeFailed_ReturnsViewWithModel()
    {
        var user = new ApplicationUser();
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);
        _mockUserManager.Setup(u => u.SetEmailAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Failed(new IdentityError { Description = "Email change failed." }));

        var result = await _accountManagementController.EmailChange(new EmailChangeModel());

        Assert.IsInstanceOf<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.IsInstanceOf<EmailChangeModel>(viewResult.Model);
    }

    [Test]
    public async Task EmailChange_Post_UserNotFound_ReturnsNotFound()
    {
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync((ApplicationUser)null);

        var result = await _accountManagementController.EmailChange(new EmailChangeModel());

        Assert.IsInstanceOf<NotFoundObjectResult>(result);

        var notFoundResult = (NotFoundObjectResult)result;

        Assert.AreEqual($"Unable to load user with ID ''.", notFoundResult.Value);
    }

    [Test]
    public async Task EmailChange_Post_InvalidModelState_ReturnsViewWithModel()
    {
        var user = new ApplicationUser();
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);

        _accountManagementController.ModelState.AddModelError("NewEmail", "The NewEmail field is required.");

        var result = await _accountManagementController.EmailChange(new EmailChangeModel());

        Assert.IsInstanceOf<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.IsInstanceOf<EmailChangeModel>(viewResult.Model);
    }

    [Test]
    public async Task PhoneNumberChange_Get_UserFound_ReturnsViewWithModel()
    {
        var user = new ApplicationUser();

        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);

        var result = await _accountManagementController.PhoneNumberChange();

        Assert.IsInstanceOf<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.IsInstanceOf<PhoneNumberChangeModel>(viewResult.Model);
    }

    [Test]
    public async Task PhoneNumberChange_Get_UserNotFound_ReturnsNotFound()
    {
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync((ApplicationUser)null);

        var result = await _accountManagementController.PhoneNumberChange();

        Assert.IsInstanceOf<NotFoundObjectResult>(result);

        var notFoundResult = (NotFoundObjectResult)result;

        Assert.AreEqual($"Unable to load user with ID ''.", notFoundResult.Value);
    }

    [Test]
    public async Task PhoneNumberChange_Post_UserFound_PhoneNumberChangeSuccess_ReturnsRedirectToAction()
    {
        var user = new ApplicationUser();

        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);
        _mockUserManager.Setup(u => u.GetPhoneNumberAsync(It.IsAny<ApplicationUser>())).ReturnsAsync("1234567890");

        _mockUserManager.Setup(u => u.SetPhoneNumberAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Success);

        var tempData = new TempDataDictionary(_accountManagementController.ControllerContext.HttpContext, Mock.Of<ITempDataProvider>());
        _accountManagementController.TempData = tempData;

        var result = await _accountManagementController.PhoneNumberChange(new PhoneNumberChangeModel());


        Assert.IsInstanceOf<RedirectToActionResult>(result);
        var redirectResult = (RedirectToActionResult)result;
        Assert.AreEqual("Index", redirectResult.ActionName);
        Assert.AreEqual("Home", redirectResult.ControllerName);

        Assert.AreEqual("Your phone number has been changed.", _accountManagementController.StatusMessage);
    }

    [Test]
    public async Task PhoneNumberChange_Post_UserFound_PhoneNumberChangeFailed_ReturnsViewWithModel()
    {
        var user = new ApplicationUser();
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);
        _mockUserManager.Setup(u => u.GetPhoneNumberAsync(It.IsAny<ApplicationUser>())).ReturnsAsync("1234567890");

        _mockUserManager.Setup(u => u.SetPhoneNumberAsync(It.IsAny<ApplicationUser>(), It.IsAny<string>())).ReturnsAsync(IdentityResult.Failed(new IdentityError { Description = "Phone number change failed." }));

        var result = await _accountManagementController.PhoneNumberChange(new PhoneNumberChangeModel());

        Assert.IsInstanceOf<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.IsInstanceOf<PhoneNumberChangeModel>(viewResult.Model);
    }

    [Test]
    public async Task PhoneNumberChange_Post_UserFound_InvalidModelState_ReturnsViewWithModel()
    {
        var user = new ApplicationUser();
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);

        _accountManagementController.ModelState.AddModelError("NewPhoneNumber", "The NewPhoneNumber field is required.");

        var result = await _accountManagementController.PhoneNumberChange(new PhoneNumberChangeModel());

        Assert.IsInstanceOf<ViewResult>(result);
        var viewResult = (ViewResult)result;
        Assert.IsInstanceOf<PhoneNumberChangeModel>(viewResult.Model);
    }

    [Test]
    public async Task PhoneNumberChange_Post_UserNotFound_ReturnsNotFound()
    {
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync((ApplicationUser)null);

        var result = await _accountManagementController.PhoneNumberChange(new PhoneNumberChangeModel());

        Assert.IsInstanceOf<NotFoundObjectResult>(result);
        var notFoundResult = (NotFoundObjectResult)result;

        Assert.AreEqual($"Unable to load user with ID ''.", notFoundResult.Value);
    }

    [Test]
    public async Task DownloadPersonalData_UserFound_ReturnsJsonFile()
    {
        var user = new ApplicationUser();
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);
        _mockUserManager.Setup(u => u.GetLoginsAsync(It.IsAny<ApplicationUser>())).ReturnsAsync(new List<UserLoginInfo>());

        _mockUserManager.Setup(u => u.GetAuthenticatorKeyAsync(It.IsAny<ApplicationUser>())).ReturnsAsync("AuthKey");

        var result = await _accountManagementController.DownloadPersonalData();

        Assert.IsInstanceOf<FileContentResult>(result);
        var fileResult = (FileContentResult)result;
        Assert.AreEqual("PersonalData.json", fileResult.FileDownloadName);
        Assert.AreEqual("application/json; charset=utf-16", fileResult.ContentType);
    }

    [Test]
    public async Task DownloadPersonalData_UserFound_NoPersonalData_ReturnsJsonFile()
    {
        var user = new ApplicationUser();
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);
        _mockUserManager.Setup(u => u.GetLoginsAsync(It.IsAny<ApplicationUser>())).ReturnsAsync(new List<UserLoginInfo>());

        _mockUserManager.Setup(u => u.GetAuthenticatorKeyAsync(It.IsAny<ApplicationUser>())).ReturnsAsync("AuthKey");

        var result = await _accountManagementController.DownloadPersonalData();


        Assert.IsInstanceOf<FileContentResult>(result);
        var fileResult = (FileContentResult)result;
        Assert.AreEqual("PersonalData.json", fileResult.FileDownloadName);
        Assert.AreEqual("application/json; charset=utf-16", fileResult.ContentType);
    }

    [Test]
    public async Task DownloadPersonalData_UserNotFound_ReturnsNotFound()
    {
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync((ApplicationUser)null);

        var result = await _accountManagementController.DownloadPersonalData();

        Assert.IsInstanceOf<NotFoundObjectResult>(result);
    }

    [Test]
    public async Task DeletePersonalData_Post_UserFound_ConfirmationMatches_ReturnsRedirectToAction()
    {
        var user = new ApplicationUser();
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);
        _mockUserManager.Setup(u => u.UpdateAsync(It.IsAny<ApplicationUser>())).ReturnsAsync(IdentityResult.Success);

        var result = await _accountManagementController.DeletePersonalData(new DeletePersonalDataModel { Confirmation = "DELETE" });

        Assert.IsInstanceOf<RedirectToActionResult>(result);
        var redirectResult = (RedirectToActionResult)result;

        Assert.AreEqual("Index", redirectResult.ActionName);
        Assert.AreEqual("Home", redirectResult.ControllerName);
    }

    [Test]
    public async Task DeletePersonalData_Post_UserFound_ConfirmationDoesNotMatch_ReturnsViewWithModel()
    {
        var user = new ApplicationUser();
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);

        var result = await _accountManagementController.DeletePersonalData(new DeletePersonalDataModel { Confirmation = "WRONG" });

        Assert.IsInstanceOf<ViewResult>(result);
        var viewResult = (ViewResult)result;

        Assert.IsInstanceOf<DeletePersonalDataModel>(viewResult.Model);
    }

    [Test]
    public async Task DeletePersonalData_Post_UserFound_InvalidModelState_ReturnsViewWithModel()
    {
        var user = new ApplicationUser();
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync(user);

        var result = await _accountManagementController.DeletePersonalData(new DeletePersonalDataModel());

        Assert.IsInstanceOf<ViewResult>(result);
        var viewResult = (ViewResult)result;

        Assert.IsInstanceOf<DeletePersonalDataModel>(viewResult.Model);
    }

    [Test]
    public async Task DeletePersonalData_Post_UserNotFound_ReturnsNotFound()
    {
        _mockUserManager.Setup(u => u.GetUserAsync(It.IsAny<ClaimsPrincipal>())).ReturnsAsync((ApplicationUser)null);

        var result = await _accountManagementController.DeletePersonalData(new DeletePersonalDataModel { Confirmation = "DELETE" });

        Assert.IsInstanceOf<NotFoundObjectResult>(result);
        var notFoundResult = (NotFoundObjectResult)result;

        Assert.AreEqual($"Unable to load user with ID ''.", notFoundResult.Value);
    }
}