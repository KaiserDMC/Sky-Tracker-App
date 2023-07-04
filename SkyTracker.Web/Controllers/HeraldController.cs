namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using SkyTracker.Services.Data.Interfaces;

[Authorize]
public class HeraldController : Controller
{
    private readonly IHeraldService _heraldService;

    public HeraldController(IHeraldService heraldService)
    {
        _heraldService = heraldService;
    }

    [HttpGet]
    public async Task<IActionResult> All()
    {
        var heralds = await _heraldService.GetAllHeraldsAsync();

        return View(heralds);
    }

    [HttpGet]
    public async Task<IActionResult> AllSortedHeraldByTypeAsc()
    {
        var heralds = await _heraldService.GetAllHeraldsSortedByTypeAscAsync();

        return View(heralds);
    }

    [HttpGet]
    public async Task<IActionResult> AllSortedHeraldByTypeDesc()
    {
        var heralds = await _heraldService.GetAllHeraldsSortedByTypeDescAsync();

        return View(heralds);
    }
}