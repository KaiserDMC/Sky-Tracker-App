namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Mvc;

public class RadarController : Controller
{
    public async Task<IActionResult> Map()
    {
        return View();
    }
}