namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using SkyTracker.Services.Data.Interfaces;

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

        int pageSize = 25;

        int pageNumber = (page ?? 1);

        var pagedData = flights.ToPagedList(pageNumber, pageSize);

        return PartialView("_FlightsPartial", pagedData);
    }

    public async Task<IActionResult> AircraftPartial()
    {
        var aircraft = await _adminService.GetAircraftAsync();

        return PartialView("_AircraftPartial", aircraft);
    }

    public async Task<IActionResult> AirportsPartial()
    {
        var airports = await _adminService.GetAirportsAsync();

        return PartialView("_AirportsPartial", airports);
    }

    public async Task<IActionResult> HeraldsPartial()
    {
        var heralds = await _adminService.GetHeraldsAsync();

        return PartialView("_HeraldsPartial", heralds);
    }

    public async Task<IActionResult> UsersPartial()
    {
        var users = await _adminService.GetUsersAsync();

        return PartialView("_UsersPartial", users);
    }
}