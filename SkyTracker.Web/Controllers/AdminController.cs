using Microsoft.AspNetCore.Authorization;

namespace SkyTracker.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    public async Task<IActionResult> Index()
    {
        return View();
    }
}