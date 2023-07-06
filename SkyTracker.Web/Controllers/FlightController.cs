namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using SkyTracker.Services.Data.Interfaces;

[Authorize]
public class FlightController : Controller
{
    private readonly IFlightService _flightService;

    public FlightController(IFlightService flightService)
    {
        _flightService = flightService;
    }

    public async Task<IActionResult> All()
    {
        var flights = await _flightService.GetAllFlightsAsync();

        return View(flights);
    }

    public async Task<IActionResult> AllSortedFlightByIdDesc()
    {
        var flights = await _flightService.GetAllFlightsSortedByFlightIdDescAsync();

        return View(flights);
    }

    public async Task<IActionResult> AllSortedFlightByArpAsc()
    {
        var flights = await _flightService.GetAllFlightsSortedByArpAscAsync();

        return View(flights);
    }

    public async Task<IActionResult> AllSortedFlightByArpDesc()
    {
        var flights = await _flightService.GetAllFlightsSortedByArpDescAsync();

        return View(flights);
    }
}