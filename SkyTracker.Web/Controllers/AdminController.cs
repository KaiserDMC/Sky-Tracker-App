namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

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
}