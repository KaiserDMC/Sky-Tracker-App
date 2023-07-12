namespace SkyTracker.Web.Controllers;


using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using ViewModels.Flight;
using SkyTracker.Services.Data.Interfaces;
using static Common.GeneralApplicationContants;

using X.PagedList;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    private readonly IAdminService _adminService;

    public AdminController(IAdminService adminService)
    {
        _adminService = adminService;
    }

    public async Task<IActionResult> Index()
    {
        return View();
    }

    public async Task<IActionResult> FlightsPartial(int? page)
    {
        var flights = await _adminService.GetFlightsAsync();

        int pageSize = DefaultAdminListEntitiesPerPage;

        int pageNumber = (page ?? 1);

        var pagedData = flights.ToPagedList(pageNumber, pageSize);

        return PartialView("_FlightsPartial", pagedData);
    }

    public async Task<IActionResult> AircraftPartial(int? page)
    {
        var aircraft = await _adminService.GetAircraftAsync();

        int pageSize = DefaultAdminListEntitiesPerPage;

        int pageNumber = (page ?? 1);


        var pagedData = aircraft.ToPagedList(pageNumber, pageSize);

        return PartialView("_AircraftPartial", pagedData);
    }

    public async Task<IActionResult> AirportsPartial(int? page)
    {
        var airports = await _adminService.GetAirportsAsync();

        int pageSize = DefaultAdminListEntitiesPerPage;

        int pageNumber = (page ?? 1);

        var pagedData = airports.ToPagedList(pageNumber, pageSize);

        return PartialView("_AirportsPartial", pagedData);
    }

    public async Task<IActionResult> HeraldsPartial(int? page)
    {
        var heralds = await _adminService.GetHeraldsAsync();

        int pageSize = DefaultAdminListEntitiesPerPage;

        int pageNumber = (page ?? 1);

        var pagedData = heralds.ToPagedList(pageNumber, pageSize);

        return PartialView("_HeraldsPartial", pagedData);
    }

    public async Task<IActionResult> UsersPartial(int? page)
    {
        var users = await _adminService.GetUsersAsync();

        int pageSize = DefaultAdminListEntitiesPerPage;

        int pageNumber = (page ?? 1);

        var pagedData = users.ToPagedList(pageNumber, pageSize);

        return PartialView("_UsersPartial", pagedData);
    }

    [HttpGet]
    public async Task<IActionResult> AddFlight()
    {
        var airports = await _adminService.GetAirportsCollectionAsync();

        FlightFormModel model = new FlightFormModel()
        {
            AirportListDeparture = airports,
            AirportListArrival = airports,
            AirportListActual = airports,
            AirporListReserved = airports
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> AddFlight(FlightFormModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        
        try
        {
            await _adminService.AddFlightAsync(model);
        }
        catch
        {
            return BadRequest();
        }

        if (!string.IsNullOrEmpty(model.Error))
        {
            return View(model);
        }

        return RedirectToAction("Index", "Admin");
    }

    [HttpGet]
    public async Task<IActionResult> EditFlight(string flightId)
    {
        var airports = await _adminService.GetAirportsCollectionAsync();

        var flight = await _adminService.GetFlightbyIdAsync(flightId);

        flight.AirportListDeparture = airports;
        flight.AirportListArrival = airports;
        flight.AirportListActual = airports;
        flight.AirporListReserved = airports;

        return View(flight);
    }

    [HttpPost]
    public async Task<IActionResult> EditFlight(string flightId, FlightFormModel model)
    {
        var airports = await _adminService.GetAirportsCollectionAsync();

        var flight = await _adminService.GetFlightbyIdAsync(flightId);

        flight.AirportListDeparture = airports;
        flight.AirportListArrival = airports;
        flight.AirportListActual = airports;
        flight.AirporListReserved = airports;

        model.AirportListDeparture = airports;
        model.AirportListArrival = airports;
        model.AirportListActual = airports;
        model.AirporListReserved = airports;

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        flight.Registration = model.Registration;
        flight.Equipment = model.Equipment;
        flight.Callsign = model.Callsign;
        flight.FlightNumber = model.FlightNumber;
        flight.DepartureId = model.DepartureId;
        flight.ScheduledArrival = model.ScheduledArrival;
        flight.RealArrival = model.RealArrival;
        flight.Reserved = model.Reserved;

        try
        {
            await _adminService.EditFlightAsync(flightId, model);
        }
        catch
        {
            return BadRequest();
        }

        return RedirectToAction("Index", "Admin");
    }

    [HttpPost]
    public async Task<IActionResult> DeleteFlight(string[] flightIds)
    {
        try
        {
            await _adminService.DeleteFlightAsync(flightIds);
            return Json(new { success = true });
        }
        catch
        {
            return Json(new { success = false });
        }
    }

    [HttpGet]
    public async Task<IActionResult> DeletedHistoryFlights()
    {
        IEnumerable<FlightAllViewModel> deletedFlights;

        try
        {
            deletedFlights =  await _adminService.GetDeletedFlightsAsync();
        }
        catch
        {
            return BadRequest();
        }

        return PartialView("_DeletedFlightsPartial", deletedFlights);
    }
}