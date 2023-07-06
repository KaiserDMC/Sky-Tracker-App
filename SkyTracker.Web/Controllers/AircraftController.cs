namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using SkyTracker.Services.Data.Interfaces;

[Authorize]
public class AircraftController : Controller
{
    private readonly IAircraftService _aircraftService;

    public AircraftController(IAircraftService aircraftService)
    {
        _aircraftService = aircraftService;
    }

    public async Task<IActionResult> All()
    {
        var aircraft = await _aircraftService.GetAllAircraftAsync();

        return View(aircraft);
    }

    public async Task<IActionResult> GetDetailsAircraft(string aircraftId)
    {
        var aircraft = await _aircraftService.GetAircraftDetailsByIdAsync(aircraftId);

        return View(aircraft);
    }
}