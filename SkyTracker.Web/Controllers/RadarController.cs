namespace SkyTracker.Web.Controllers;

using SkyTracker.Services.Data.Interfaces;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
public class RadarController : Controller
{
    private readonly IRadarService _radarService;

    public RadarController(IRadarService radarService)
    {
        _radarService = radarService;
    }

    public async Task<IActionResult> Map()
    {
        var airportAndFlightDataLocations = await _radarService.GetFlightAndAirportDataAsync();

        return View(airportAndFlightDataLocations);
    }
}