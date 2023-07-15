using System.Drawing;

using SkyTracker.Data.Models;
using SkyTracker.Web.ViewModels.Aircraft;

namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Azure.Storage.Blobs;

using Configuration;
using SkyTracker.Services.Data.Interfaces;
using static SkyTracker.Common.GeneralApplicationContants;
using System.Web.Helpers;
using static SkyTracker.Common.DataModelsValidationConstants;
using static SkyTracker.Web.Configuration.UploadBlob;

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

    public async Task<IActionResult> All()
    {
        var aircraft = await _aircraftService.GetAllAircraftAsync();

        return View(aircraft);
    }

    public async Task<IActionResult> GetDetailsAircraft(string aircraftId)
    {
        var aircraft = await _aircraftService.GetAircraftDetailsByIdAsync(aircraftId);

        BlobContainerClient blobAircraft = _blobServiceClient.GetBlobContainerClient(AircraftImagesContainerName);

        BlobClient blob = blobAircraft.GetBlobClient(aircraft.Registration.ToLower() + ".jpg");

        string localPath = Path.Combine(_hostingEnvironment.WebRootPath, AircraftImagesBlobRelativePath, aircraft.Registration.ToLower() + ".jpg");

        if (await blob.ExistsAsync())
        {
            await DownloadBlob.DownloadBlobToFileAsync(blob, localPath);

            aircraft.ImageUrl = Path.Combine(AircraftImagesBlobRelativePath, aircraft.Registration.ToLower() + ".jpg");
        }
        else
        {
            blobAircraft = _blobServiceClient.GetBlobContainerClient(StockImagesContainerName);
            blob = blobAircraft.GetBlobClient("stock-aircraft-img" + ".png");
            localPath = Path.Combine(_hostingEnvironment.WebRootPath, StockImagesBlobRelativePath, "stock-aircraft-img" + ".png");

            await DownloadBlob.DownloadBlobToFileAsync(blob, localPath);

            aircraft.ImageUrl = Path.Combine(StockImagesBlobRelativePath, "stock-aircraft-img" + ".png");
        }

        return View(aircraft);
    }

    private async Task<string> UploadPicture()
    {
        //Reads the form data from the request body.
        var form = await Request.ReadFormAsync();

        if (form.Files.Count == 0)
        {
            return string.Empty;
        }

        //Gets the first file and saves it to the specified path.
        var file = form.Files.First();
        var registration = form["Registration"].ToString().ToLower();
        var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "temp", registration + ".jpg");

        Image image = Image.FromStream(file.OpenReadStream(), true, true);

        Bitmap newImage = new Bitmap(image);
        SaveFileLocal(filePath, newImage);

        return filePath;
    }

    private static void SaveFileLocal(string filePath, Bitmap newImage)
    {
        using (var stream = new MemoryStream())
        {
            newImage.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

            var imageBytes = stream.ToArray();

            //Save the file to the local folder
            using (var str = new FileStream(
                       filePath, FileMode.Create, FileAccess.Write, FileShare.Write, 4096))
            {
                str.Write(imageBytes, 0, imageBytes.Length);
            }
        }
    }


    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> AddAircraft()
    {
        AircraftFormModel aircraft = new AircraftFormModel();

        return View(aircraft);
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> AddAircraft(AircraftFormModel model)
    {

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        try
        {
            var picturePath = await UploadPicture();

            if (string.IsNullOrEmpty(picturePath))
            {
                BlobContainerClient blobAircraft = _blobServiceClient.GetBlobContainerClient(StockImagesContainerName);
                BlobClient blob = blobAircraft.GetBlobClient("stock-aircraft-img" + ".png");

                string localPath = Path.Combine(_hostingEnvironment.WebRootPath, StockImagesBlobRelativePath, "stock-aircraft-img" + ".png");

                await DownloadBlob.DownloadBlobToFileAsync(blob, localPath);

                model.ImagePathUrl = Path.Combine(StockImagesBlobRelativePath, "stock-aircraft-img" + ".png");
            }
            else
            {
                BlobContainerClient blobAircraft = _blobServiceClient.GetBlobContainerClient(AircraftImagesContainerName);

                await UploadFromFileAsync(blobAircraft, picturePath);
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

        return RedirectToAction("Index", "Home");
        //return RedirectToAction("Index", "Admin");
    }

    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> EditAircraft(string aircraftId)
    {
        var aircraft = await _aircraftService.GetAircraftbyIdAsync(aircraftId);

        return View(aircraft);
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
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
            await _aircraftService.EditAircraftAsync(aircraftId, model);
        }
        catch
        {
            return BadRequest();
        }

        return RedirectToAction("Index", "Admin");
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteAircraft(string[] aircraftIds)
    {
        try
        {
            await _aircraftService.DeleteAircraftAsync(aircraftIds);
            return Json(new { success = true });
        }
        catch
        {
            return Json(new { success = false });
        }
    }

    [HttpGet]
    [Authorize(Roles = "Admin")]
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
}