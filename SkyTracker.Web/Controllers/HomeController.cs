using SkyTracker.Services.Data.Interfaces;

namespace SkyTracker.Web.Controllers;

using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

using ViewModels.Home;

public class HomeController : Controller
{
    private readonly IHomeService _homeService;

    public HomeController(IHomeService homeService)
    {
        _homeService = homeService;
    }

    public IActionResult Index()
    {
        var statusMessage = TempData["StatusMessage"] as string;

        if (!string.IsNullOrEmpty(statusMessage))
        {
            ViewBag.StatusMessage = statusMessage;
        }

        var heraldNews = GetLatestHeraldNewsAsync().GetAwaiter().GetResult();
        
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private async Task<IEnumerable<HeraldNewsModel>> GetLatestHeraldNewsAsync()
    {
        var heraldNews = await _homeService.GetLatestHeraldNewsAsync();

        return heraldNews;
    }
}