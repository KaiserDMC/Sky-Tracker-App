namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using SkyTracker.Services.Data.Interfaces;

/// <summary>
/// Radar Controller. Used to display the map with the flight and airport data.
/// </summary>

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