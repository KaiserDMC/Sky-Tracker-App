using SkyTracker.Services.Data.Interfaces;

namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
public class SearchController : Controller
{
    private readonly ISearchService _searchService;

    public SearchController(ISearchService searchService)
    {
        _searchService = searchService;
    }

    public async Task<IActionResult> IndexSearch(string query, string[] properties, string modelType)
    {
        switch (modelType)
        {
            case "aircraft":
                var aircraftResults = await _searchService.SearchAircraftAsync(query, properties);
                ViewBag.AircraftResults = aircraftResults;
                break;
            case "airports":
                var airportResults = await _searchService.SearchAirportsAsync(query, properties);
                ViewBag.AirportResults = airportResults;
                break;
            case "flights":
                var flightResults = await _searchService.SearchFlightsAsync(query, properties);
                ViewBag.FlightResults = flightResults;
                break;
        }

        return View();
    }
}