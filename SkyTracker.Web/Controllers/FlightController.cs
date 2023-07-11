namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using ViewModels.Flight;
using SkyTracker.Services.Data.Interfaces;

using X.PagedList;

[Authorize]
public class FlightController : Controller
{
    private readonly IFlightService _flightService;

    public FlightController(IFlightService flightService)
    {
        _flightService = flightService;
    }

    public async Task<IActionResult> All(string sortType, int? page, int? pageSize)
    {
        IEnumerable<FlightAllViewModel> flights;

        int pageNumber = page ?? 1;
        int itemsPerPage = pageSize ?? 10;

        switch (sortType)
        {
            case "id_desc":
                flights = await _flightService.GetAllFlightsSortedByFlightIdDescAsync();
                break;
            case "arp_asc":
                flights = await _flightService.GetAllFlightsSortedByArpAscAsync();
                break;
            case "arp_desc":
                flights = await _flightService.GetAllFlightsSortedByArpDescAsync();
                break;
            default:
                flights = await _flightService.GetAllFlightsAsync();
                break;
        }

        var totalItemCount = flights.Count();

        var totalPages = (int)Math.Ceiling((double)totalItemCount / itemsPerPage);
        if (pageNumber > totalPages || itemsPerPage != pageSize)
        {
            pageNumber = 1;
        }

        var pagedFlights = flights.ToPagedList(pageNumber, itemsPerPage);

        var updatedPagedList = new StaticPagedList<FlightAllViewModel>(pagedFlights, pagedFlights.GetMetaData());

        var updatedPagedListWithPageNumber = new StaticPagedList<FlightAllViewModel>(
            updatedPagedList, pageNumber, itemsPerPage, updatedPagedList.TotalItemCount);

        return View(updatedPagedListWithPageNumber);
    }


    public async Task<IActionResult> GetDetailsFlight(string flightId)
    {
        var flight = await _flightService.GetFlightDetailsByIdAsync(flightId);

        return View(flight);
    }
}