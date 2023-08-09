namespace SkyTracker.Web.Controllers;

using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

using SkyTracker.Services.Data.Interfaces;

using ViewModels.Home;

using static Common.UserRoleNames;

/// <summary>
/// Home Controller. Provides the main landing page for the application.
/// Plus Privacy and Error pages.
/// </summary>

public class HomeController : Controller
{
    private readonly IHomeService _homeService;

    public HomeController(IHomeService homeService)
    {
        _homeService = homeService;
    }

    public async Task<IActionResult> Index()
    {
        if (this.User.IsInRole(AdminRole))
        {
            return this.RedirectToAction("Index", "AdminPanel", new { Area = AdminRole });
        }

        var statusMessage = TempData["StatusMessage"] as string;

        // This is only for Unit Testing

        //var tempData = ControllerContext.HttpContext.Items["__ControllerTempData"] as TempDataDictionary;
        //var statusMessage = String.Empty;
        
        //if (tempData != null)
        //{
        //    statusMessage = tempData["StatusMessage"] as string;
        //}

        if (!string.IsNullOrEmpty(statusMessage))
        {
            ViewBag.StatusMessage = statusMessage;
        }

        var heraldNews = await GetLatestHeraldNewsAsync();
        
        var viewModel = new IndexViewModel
        {
            StatusMessage = statusMessage,
            NewsItems = heraldNews
        };

        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult AboutUs()
    {
        return View();
    }

    private async Task<IEnumerable<HeraldNewsModel>> GetLatestHeraldNewsAsync()
    {
        var heraldNews = await _homeService.GetLatestHeraldNewsAsync();

        return heraldNews;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public async Task<IActionResult> Error(int statusCode)
    {
        return statusCode switch
        {
            400 => View("Error400"),
            401 => View("Error401"),
            404 => View("Error404"),
            500 => View("Error500"),
            _ => View("Error")
        };
    }
}