namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using SkyTracker.Services.Data.Interfaces;

/// <summary>
/// Search Controller. Used to search for aircraft, airports, and flights.
/// </summary>

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
        string[] mappedProperties = properties.SelectMany(p => p.Split(',')).ToArray();

        switch (modelType)
        {
            case "aircraft":
                var aircraftResults = await _searchService.SearchAircraftAsync(query, mappedProperties);
                ViewBag.AircraftResults = aircraftResults;
                ViewBag.ModelType = modelType;
                break;
            case "airports":
                var airportResults = await _searchService.SearchAirportsAsync(query, mappedProperties);
                ViewBag.AirportResults = airportResults;
                ViewBag.ModelType = modelType;
                break;
            case "flights":
                var flightResults = await _searchService.SearchFlightsAsync(query, mappedProperties);
                ViewBag.FlightResults = flightResults;
                ViewBag.ModelType = modelType;
                break;
        }

        return View();
    }
}