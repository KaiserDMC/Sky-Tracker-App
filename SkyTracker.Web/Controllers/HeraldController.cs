namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using SkyTracker.Services.Data.Interfaces;

using ViewModels.Herald;

using X.PagedList;

using static Common.GeneralApplicationContants;
using static Common.UserRoleNames;

/// <summary>
/// Herald Controller. Used for Herald related actions.
/// </summary>

[Authorize]
public class HeraldController : Controller
{
    private readonly IHeraldService _heraldService;

    public HeraldController(IHeraldService heraldService)
    {
        _heraldService = heraldService;
    }

    [TempData]
    public string StatusMessage { get; set; }

    [HttpGet]
    public async Task<IActionResult> All(string sortType, int? page, int? pageSize)
    {
        IEnumerable<HeraldAllViewModel>? heralds;

        int pageNumber = page ?? DefaultStartPagePagination;
        int itemsPerPage = pageSize ?? DefaultListEntitiesPerPage;

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

    [HttpGet]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> AddHerald()
    {
        var types = await _heraldService.GetHeraldTypeAsync();

        var aircraftCollection = await _heraldService.GetAircraftForHerald();

        HeraldFormModel model = new HeraldFormModel
        {
            Occurrence = DateTime.UtcNow,
            HeraldTypes = types,
            AircraftHeralds = aircraftCollection
        };

        return View(model);
    }

    [HttpPost]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> AddHerald(HeraldFormModel model)
    {
        if (!ModelState.IsValid)
        {
            model.HeraldTypes = await _heraldService.GetHeraldTypeAsync();
            model.AircraftHeralds = await _heraldService.GetAircraftForHerald();

            return View(model);
        }

        try
        {
            var selectedType = model.HeraldTypes.FirstOrDefault(t => t.Type.ToString() == model.TypeOccurrence);
            if (selectedType != null)
                model.TypeOccurrence = selectedType.Type.ToString();

            await _heraldService.AddHeraldAsync(model);
        }
        catch
        {
            return BadRequest();
        }

        if (!string.IsNullOrEmpty(model.Error))
        {
            model.HeraldTypes = await _heraldService.GetHeraldTypeAsync();

            return View(model);
        }

        StatusMessage = "Herald added successfully!";
        return RedirectToAction("Index", "AdminPanel", new { area = AdminRole });
    }

    [HttpGet]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> EditHerald(string heraldId)
    {
        var heraldTypes = await _heraldService.GetHeraldTypeAsync();

        var aircraftCollection = await _heraldService.GetAircraftForHerald();

        var herald = await _heraldService.GetHeraldbyIdAsync(heraldId);

        herald.HeraldTypes = heraldTypes;
        herald.AircraftHeralds = aircraftCollection;

        return View(herald);
    }

    [HttpPost]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> EditHerald(string heraldId, HeraldFormModel model)
    {
        var heraldTypes = await _heraldService.GetHeraldTypeAsync();

        var aircraftCollection = await _heraldService.GetAircraftForHerald();

        var herald = await _heraldService.GetHeraldbyIdAsync(heraldId);

        herald.HeraldTypes = heraldTypes;
        herald.AircraftHeralds = aircraftCollection;

        if (!ModelState.IsValid)
        {
            return View(herald);
        }

        herald.Occurrence = model.Occurrence;
        herald.TypeOccurrence = model.TypeOccurrence;
        herald.Details = model.Details;
        herald.AircraftId = model.AircraftId;

        try
        {
            await _heraldService.EditHeraldAsync(heraldId, herald);
        }
        catch
        {
            return BadRequest();
        }

        StatusMessage = "Herald edited successfully!";
        return RedirectToAction("Index", "AdminPanel", new { area = AdminRole });
    }

    [HttpPost]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> DeleteHerald(string[] heraldIds)
    {
        try
        {
            await _heraldService.DeleteHeraldAsync(heraldIds);
            return Json(new { success = true, message = "Selected heralds were deleted successfully!" });
        }
        catch
        {
            return Json(new { success = false, message = "Error: Something went wrong and the selected heralds were not deleted!" });
        }
    }

    [HttpGet]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> DeletedHistoryHeralds()
    {
        IEnumerable<HeraldAllViewModel> deletedHeralds;

        try
        {
            deletedHeralds = await _heraldService.GetDeletedHeraldsAsync();
        }
        catch
        {
            return BadRequest();
        }

        return PartialView("_DeletedHeraldsPartial", deletedHeralds);
    }
}