namespace SkyTracker.Web.Areas.Admin.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using X.PagedList;

using static Common.GeneralApplicationContants;

[Area("Admin")]
[Authorize(Roles = "Admin, Moderator")]
public class AdminPanelController : Controller
{
    private readonly IAdminService _adminService;

    public AdminPanelController(IAdminService adminService)
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

        int pageNumber = page ?? DefaultStartPagePagination;

        var pagedData = flights.ToPagedList(pageNumber, pageSize);

        return PartialView("_FlightsPartial", pagedData);
    }

    public async Task<IActionResult> AircraftPartial(int? page)
    {
        var aircraft = await _adminService.GetAircraftAsync();

        int pageSize = DefaultAdminListEntitiesPerPage;

        int pageNumber = page ?? DefaultStartPagePagination;


        var pagedData = aircraft.ToPagedList(pageNumber, pageSize);

        return PartialView("_AircraftPartial", pagedData);
    }

    public async Task<IActionResult> AirportsPartial(int? page)
    {
        var airports = await _adminService.GetAirportsAsync();

        int pageSize = DefaultAdminListEntitiesPerPage;

        int pageNumber = page ?? DefaultStartPagePagination;

        var pagedData = airports.ToPagedList(pageNumber, pageSize);

        return PartialView("_AirportsPartial", pagedData);
    }

    public async Task<IActionResult> HeraldsPartial(int? page)
    {
        var heralds = await _adminService.GetHeraldsAsync();

        int pageSize = DefaultAdminListEntitiesPerPage;

        int pageNumber = page ?? DefaultStartPagePagination;

        var pagedData = heralds.ToPagedList(pageNumber, pageSize);

        return PartialView("_HeraldsPartial", pagedData);
    }
}