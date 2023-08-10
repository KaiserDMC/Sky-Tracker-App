namespace SkyTracker.Web.Controllers;

using Azure.Storage.Blobs;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using SkyTracker.Services.Data.Interfaces;
using Configuration;

using ViewModels.Aircraft;

using static Common.GeneralApplicationContants;
using static Common.UserRoleNames;
using static Configuration.UploadBlob;

/// <summary>
/// Aircraft Controller. Used for managing aircrafts.
/// </summary>

[Authorize]
public class AircraftController : Controller
{
    private readonly IAircraftService _aircraftService;
    private readonly BlobServiceClient _blobServiceClient;
    private readonly IWebHostEnvironment _hostingEnvironment;

    public AircraftController(IAircraftService aircraftService, BlobServiceClient blobServiceClient, IWebHostEnvironment hostingEnvironment)
    {
        _aircraftService = aircraftService;
        _blobServiceClient = blobServiceClient;
        _hostingEnvironment = hostingEnvironment;
    }

    [TempData]
    public string StatusMessage { get; set; }

    [HttpGet]
    public async Task<IActionResult> All()
    {
        var aircraft = await _aircraftService.GetAllAircraftAsync();

        return View(aircraft);
    }

    [HttpGet]
    public async Task<IActionResult> GetDetailsAircraft(string aircraftId)
    {
        var aircraft = await _aircraftService.GetAircraftDetailsByIdAsync(aircraftId);

        string localPath = Path.Combine(_hostingEnvironment.WebRootPath, AircraftImagesBlobRelativePath, aircraft.Registration.ToLower());

        if (System.IO.File.Exists(Path.ChangeExtension(localPath, ".jpg")))
        {
            aircraft.ImageUrl = Path.Combine(AircraftImagesBlobRelativePath, aircraft.Registration.ToLower() + ".jpg");
        }
        else if (System.IO.File.Exists(Path.ChangeExtension(localPath, ".png")))
        {
            aircraft.ImageUrl = Path.Combine(AircraftImagesBlobRelativePath, aircraft.Registration.ToLower() + ".png");
        }
        else
        {
            aircraft.ImageUrl = Path.Combine(StockImagesBlobRelativePath, "stock-aircraft-img" + ".png");
        }

        return View(aircraft);
    }

    [HttpGet]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> AddAircraft()
    {
        AircraftFormModel aircraft = new AircraftFormModel();

        return View(aircraft);
    }

    [HttpPost]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> AddAircraft(AircraftFormModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        try
        {
            var form = await Request.ReadFormAsync();
            var picturePath = await ImageHelper.UploadAircraftPicture(form.Files.FirstOrDefault(), model.Registration, _hostingEnvironment.WebRootPath);

            if (string.IsNullOrEmpty(picturePath))
            {
                model.ImagePathUrl = Path.Combine(StockImagesBlobRelativePath, "stock-aircraft-img" + ".png");
            }
            else
            {
                BlobContainerClient blobAircraft = _blobServiceClient.GetBlobContainerClient(AircraftImagesContainerName);

                await UploadFromFileAsync(blobAircraft, picturePath);

                model.ImagePathUrl = Path.Combine(AircraftImagesBlobRelativePath, model.Registration.ToLower() + ".jpg");

                ImageHelper.SynchronizeAircraftImages(_hostingEnvironment.WebRootPath, model.Registration.ToLower());
            }

            await _aircraftService.AddAircraftAsync(model);
        }
        catch
        {
            return BadRequest();
        }

        if (!string.IsNullOrEmpty(model.Error))
        {
            return View(model);
        }

        StatusMessage = "Aircraft added successfully!";
        return RedirectToAction("Index", "AdminPanel", new { area = AdminRole });
    }

    [HttpGet]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> EditAircraft(string aircraftId)
    {
        var aircraft = await _aircraftService.GetAircraftbyIdAsync(aircraftId);

        return View(aircraft);
    }

    [HttpPost]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> EditAircraft(string aircraftId, AircraftFormModel model)
    {
        var aircraft = await _aircraftService.GetAircraftbyIdAsync(aircraftId);

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        aircraft.Registration = model.Registration;
        aircraft.Equipment = model.Equipment;

        try
        {
            var form = await Request.ReadFormAsync();
            var picturePath = await ImageHelper.UploadAircraftPicture(form.Files.FirstOrDefault(), model.Registration, _hostingEnvironment.WebRootPath);

            if (!string.IsNullOrEmpty(picturePath))
            {
                BlobContainerClient blobAircraft = _blobServiceClient.GetBlobContainerClient(AircraftImagesContainerName);

                await UploadFromFileAsync(blobAircraft, picturePath);

                model.ImagePathUrl = Path.Combine(AircraftImagesBlobRelativePath, model.Registration.ToLower() + ".jpg");

                ImageHelper.SynchronizeAircraftImages(_hostingEnvironment.WebRootPath, model.Registration.ToLower());
            }
            else
            {
                model.ImagePathUrl = aircraft.ImagePathUrl;
            }

            await _aircraftService.EditAircraftAsync(aircraftId, model);
        }
        catch
        {
            return BadRequest();
        }

        StatusMessage = "Aircraft edited successfully!";
        return RedirectToAction("Index", "AdminPanel", new { area = AdminRole });
    }

    [HttpPost]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> DeleteAircraft(string[] aircraftIds)
    {
        try
        {
            var picturesToDelete = await _aircraftService.GetAircraftPictureIdsAsync(aircraftIds);

            await _aircraftService.DeleteAircraftAsync(aircraftIds);

            await ImageHelper.DeleteAircraftImages(_hostingEnvironment.WebRootPath, picturesToDelete.ToArray());

            return Json(new { success = true, message = "Selected aircraft were deleted successfully!" });
        }
        catch
        {
            return Json(new { success = false, message = "Error: Something went wrong and the selected aircraft were not deleted!" });
        }
    }

    [HttpGet]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> DeletedHistoryAircraft()
    {
        IEnumerable<AircraftAllViewModel> deletedAircraft;

        try
        {
            deletedAircraft = await _aircraftService.GetDeletedAircraftAsync();
        }
        catch
        {
            return BadRequest();
        }

        return PartialView("_DeletedAircraftPartial", deletedAircraft);
    }

    [HttpPost]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> RepairAircraft(string[] aircraftIds)
    {
        try
        {
            await _aircraftService.RepairAircraftAsync(aircraftIds);

            return Json(new { success = true, message = "Selected aircraft repaired successfully!" });
        }
        catch
        {
            return Json(new { success = false, message = "Error: Something went wrong and the selected aircraft were not repaired!" });
        }
    }

    [HttpGet]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> TotaledAircraft()
    {
        IEnumerable<AircraftAllViewModel> totaledAircraft;

        try
        {
            totaledAircraft = await _aircraftService.GetTotaledAircraftAsync();
        }
        catch
        {
            return BadRequest();
        }

        return PartialView("_TotaledAircraftPartial", totaledAircraft);
    }
}