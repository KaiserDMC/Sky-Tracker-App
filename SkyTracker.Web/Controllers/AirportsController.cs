namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using SkyTracker.Services.Data.Interfaces;

[Authorize]
public class AirportsController : Controller
{
    private readonly IAirportsService _airportsService;

    public AirportsController(IAirportsService airportsService)
    {
        _airportsService = airportsService;
    }

    public async Task<IActionResult> All()
    {
        var airports = await _airportsService.GetAllAirportsAsync();

        return View(airports);
    }

    public async Task<IActionResult> GetDetailsAirport(string iata)
    {
        var airport = await _airportsService.GetAirportDetailsByIata(iata);

        return View(airport);
    }
}