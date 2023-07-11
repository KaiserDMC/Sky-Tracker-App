namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using SkyTracker.Services.Data.Interfaces;
using ViewModels.Herald;

using X.PagedList;

[Authorize]
public class HeraldController : Controller
{
    private readonly IHeraldService _heraldService;

    public HeraldController(IHeraldService heraldService)
    {
        _heraldService = heraldService;
    }

    [HttpGet]
    public async Task<IActionResult> All(string sortType, int? page, int? pageSize)
    {
        IEnumerable<HeraldAllViewModel>? heralds;

        int pageNumber = page ?? 1;
        int itemsPerPage = pageSize ?? 10;

        switch (sortType)
        {
            case "date_asc":
                heralds = await _heraldService.GetAllHeraldsSortedByDateAscAsync();
                break;
            case "type_asc":
                heralds = await _heraldService.GetAllHeraldsSortedByTypeAscAsync();
                break;
            case "type_desc":
                heralds = await _heraldService.GetAllHeraldsSortedByTypeDescAsync();
                break;
            default:
                heralds = await _heraldService.GetAllHeraldsAsync();
                break;
        }

        var totalItemCount = heralds.Count();

        var totalPages = (int)Math.Ceiling((double)totalItemCount / itemsPerPage);
        if (pageNumber > totalPages || itemsPerPage != pageSize)
        {
            pageNumber = 1;
        }

        var pagedHeralds = heralds.ToPagedList(pageNumber, itemsPerPage);

        var updatedPagedList = new StaticPagedList<HeraldAllViewModel>(pagedHeralds, pagedHeralds.GetMetaData());

        var updatedPagedListWithPageNumber = new StaticPagedList<HeraldAllViewModel>(
            updatedPagedList, pageNumber, itemsPerPage, totalItemCount);

        return View(updatedPagedListWithPageNumber);
    }

    [HttpGet]
    public async Task<IActionResult> GetDetails(string occurrenceId)
    {
        var occurence = await _heraldService.GetDetailsById(occurrenceId);

        return View(occurence);
    }
}