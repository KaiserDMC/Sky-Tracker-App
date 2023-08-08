namespace SkyTracker.Controllers.Tests;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

using Moq;

using SkyTracker.Services.Data.Interfaces;
using SkyTracker.Web.Controllers;

using Web.ViewModels.Home;

/// <summary>
/// Home Controller Unit Tests using Moq
/// </summary>

public class HomeControllerTests
{
    private HomeController _homeController;
    private IServiceProvider _serviceProvider;

    [OneTimeSetUp]
    public void SetUp() => this._homeController = new HomeController(null);

    [Test]
    public async Task Index_ShouldWork_ReturnIndexViewResult()
    {
        var mockTempDataProvider = new Mock<ITempDataProvider>();
        
        var tempData = new TempDataDictionary(new DefaultHttpContext(), mockTempDataProvider.Object);

        tempData["StatusMessage"] = "Test Status Message";

        var controllerContext = new ControllerContext()
        {
            HttpContext = new DefaultHttpContext()
            {
                RequestServices = _serviceProvider
            }
        };

        controllerContext.HttpContext.Items["__ControllerTempData"] = tempData;

        var mockNewsService = new Mock<IHomeService>();
        var controller = new HomeController(mockNewsService.Object)
        {
            ControllerContext = controllerContext
        };

        var expectedNews = new List<HeraldNewsModel>
        {
            new HeraldNewsModel { OccurrenceDate = "2023-08-03", TypeOccurence = "Accident" },
        };

        mockNewsService.Setup(service => service.GetLatestHeraldNewsAsync())
            .ReturnsAsync(expectedNews);

        var result = await controller.Index();

        Assert.IsInstanceOf<ViewResult>(result);
        var viewResult = result as ViewResult;
        var statusMessage = viewResult.ViewData["StatusMessage"] as string;
        Assert.AreEqual("Test Status Message", statusMessage);
    }

    [Test]
    public void Privacy_ShouldWork_ReturnPrivacyViewResult()
    {
        var result = this._homeController.Privacy();

        Assert.IsInstanceOf<ViewResult>(result);
        Assert.IsNotNull(result);
    }

    [Test]
    public void Privacy_ShouldWork_ReturnAboutUsViewResult()
    {
        var result = this._homeController.AboutUs();

        Assert.IsInstanceOf<ViewResult>(result);
        Assert.IsNotNull(result);
    }

    [Test]
    public async Task Error_ShouldWork_ReturnErrorViewResult()
    {
        var result = await this._homeController.Error(404);

        Assert.IsInstanceOf<ViewResult>(result);
        Assert.IsNotNull(result);
    }

    [Test]
    public async Task Error_ShouldWork_ReturnError400ViewResult()
    {
        var result = await this._homeController.Error(400);

        Assert.IsInstanceOf<ViewResult>(result);
        Assert.IsNotNull(result);
    }

    [Test]
    public async Task Error_ShouldWork_ReturnError401ViewResult()
    {
        var result = await this._homeController.Error(401);

        Assert.IsInstanceOf<ViewResult>(result);
        Assert.IsNotNull(result);
    }

    [Test]
    public async Task Error_ShouldWork_ReturnError404ViewResult()
    {
        var result = await this._homeController.Error(404);

        Assert.IsInstanceOf<ViewResult>(result);
        Assert.IsNotNull(result);
    }

    [Test]
    public async Task Error_ShouldWork_ReturnError500ViewResult()
    {
        var result = await this._homeController.Error(500);

        Assert.IsInstanceOf<ViewResult>(result);
        Assert.IsNotNull(result);
    }

    [Test]
    public async Task Error_ShouldWork_ReturnErrorOtherViewResult()
    {
        this._homeController.ControllerContext = new ControllerContext
        {
            HttpContext = new DefaultHttpContext()
        };

        var result = await this._homeController.Error(0);

        Assert.IsInstanceOf<ViewResult>(result);
        Assert.IsNotNull(result);
    }
}