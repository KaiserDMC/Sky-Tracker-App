namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
public class RadarController : Controller
{
    public async Task<IActionResult> Map()
    {
        return View();
    }
}