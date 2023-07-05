namespace SkyTracker.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class AircraftController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
