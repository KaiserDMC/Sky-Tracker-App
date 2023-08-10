namespace SkyTracker.Web.Controllers;

using System.IO;

using Azure.Storage.Blobs;

using Configuration;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using SkyTracker.Services.Data.Interfaces;

using ViewModels.Airport;

using static Common.GeneralApplicationContants;
using static Common.UserRoleNames;
using static Configuration.UploadBlob;

/// <summary>
/// Airport Controller. Used for managing airports.
/// </summary>

[Authorize]
public class AirportController : Controller
{
    private readonly IAirportsService _airportsService;
    private readonly BlobServiceClient _blobServiceClient;
    private readonly IWebHostEnvironment _hostingEnvironment;

    public AirportController(IAirportsService airportsService, BlobServiceClient blobServiceClient, IWebHostEnvironment hostingEnvironment)
    {
        _airportsService = airportsService;
        _blobServiceClient = blobServiceClient;
        _hostingEnvironment = hostingEnvironment;
    }

    [TempData]
    public string StatusMessage { get; set; }

    [HttpGet]
    public async Task<IActionResult> All()
    {
        var airports = await _airportsService.GetAllAirportsAsync();

        return View(airports);
    }

    [HttpGet]
    public async Task<IActionResult> GetDetailsAirport(string iata)
    {
        var airport = await _airportsService.GetAirportDetailsByIata(iata);

        string localPath = Path.Combine(_hostingEnvironment.WebRootPath, AirportImagesBlobRelativePath, airport.IATA.ToLower());

        if (System.IO.File.Exists(Path.ChangeExtension(localPath, ".jpg")))
        {
            airport.ImageUrl = Path.Combine(AirportImagesBlobRelativePath, airport.IATA.ToLower() + ".jpg");
        }
        else if (System.IO.File.Exists(Path.ChangeExtension(localPath, ".png")))
        {
            airport.ImageUrl = Path.Combine(AirportImagesBlobRelativePath, airport.IATA.ToLower() + ".png");
        }
        else
        {
            airport.ImageUrl = Path.Combine(StockImagesBlobRelativePath, "stock-airport-img" + ".png");
        }

        return View(airport);
    }

    [HttpGet]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> AddAirport()
    {
        var runways = await _airportsService.GetRunwaysCollectionAsync();

        AirportFormModel model = new AirportFormModel
        {
            Runways = runways
        };

        return View(model);
    }

    [HttpPost]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> AddAirport(AirportFormModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        try
        {
            var form = await Request.ReadFormAsync();
            var picturePath = await ImageHelper.UploadAirportPicture(form.Files.FirstOrDefault(), model.IATA, _hostingEnvironment.WebRootPath);

            if (string.IsNullOrEmpty(picturePath))
            {
                model.ImagePathUrl = Path.Combine(StockImagesBlobRelativePath, "stock-airport-img" + ".png");
            }
            else
            {
                BlobContainerClient blobAirport = _blobServiceClient.GetBlobContainerClient(AirportImagesContainerName);

                await UploadFromFileAsync(blobAirport, picturePath);

                model.ImagePathUrl = Path.Combine(AirportImagesBlobRelativePath, model.IATA.ToLower() + ".jpg");

                ImageHelper.SynchronizeAirportImages(_hostingEnvironment.WebRootPath, model.IATA.ToLower());
            }

            await _airportsService.AddAirportAsync(model);
            await _airportsService.AddRunwayToAirportAsync(model.IATA, model.RunwayId);
        }
        catch
        {
            return BadRequest();
        }

        if (!string.IsNullOrEmpty(model.Error))
        {
            model.Runways = await _airportsService.GetRunwaysCollectionAsync();
            return View(model);
        }

        StatusMessage = "Airport added successfully!";
        return RedirectToAction("Index", "AdminPanel", new { area = AdminRole });
    }

    [HttpGet]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> EditAirport(string iata)
    {
        var airport = await _airportsService.GetAirportbyIataAsync(iata);

        var runways = await _airportsService.GetRunwaysCollectionAsync();

        airport.Runways = runways;

        return View(airport);
    }

    [HttpPost]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> EditAirport(string iata, AirportFormModel model)
    {
        var runways = await _airportsService.GetRunwaysCollectionAsync();

        var airport = await _airportsService.GetAirportbyIataAsync(iata);

        model.Runways = runways;

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        airport.IATA = model.IATA;
        airport.ICAO = model.ICAO;
        airport.CommonName = model.CommonName;
        airport.LocationCity = model.LocationCity;
        airport.LocationCountry = model.LocationCountry;
        airport.Lat = model.Lat;
        airport.Long = model.Long;
        airport.Elevation = model.Elevation;

        try
        {
            var form = await Request.ReadFormAsync();
            var picturePath = await ImageHelper.UploadAirportPicture(form.Files.FirstOrDefault(), model.IATA, _hostingEnvironment.WebRootPath);

            if (!string.IsNullOrEmpty(picturePath))
            {
                BlobContainerClient blobAirport = _blobServiceClient.GetBlobContainerClient(AirportImagesContainerName);

                await UploadFromFileAsync(blobAirport, picturePath);

                model.ImagePathUrl = Path.Combine(AirportImagesBlobRelativePath, airport.IATA.ToLower() + ".jpg");

                ImageHelper.SynchronizeAirportImages(_hostingEnvironment.WebRootPath, model.IATA.ToLower());
            }
            else
            {
                model.ImagePathUrl = airport.ImagePathUrl;
            }

            await _airportsService.EditAirportAsync(iata, model);
        }
        catch
        {
            return BadRequest();
        }

        StatusMessage = "Airport edited successfully!";
        return RedirectToAction("Index", "AdminPanel", new { area = AdminRole });
    }

    [HttpPost]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> DeleteAirport(string[] iataCodes)
    {
        try
        {
            await _airportsService.DeleteAirportAsync(iataCodes);
            await ImageHelper.DeleteAirportImages(_hostingEnvironment.WebRootPath, iataCodes);

            return Json(new { success = true, message= "Selected airports were deleted successfully!" });
        }
        catch
        {
            return Json(new { success = true, message = "Error: Something went wrong and the selected airports were not deleted!" });
        }
    }

    [HttpGet]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> DeletedHistoryAirports()
    {
        IEnumerable<AirportsAllViewModel> deletedAirports;
        try
        {
            deletedAirports = await _airportsService.GetDeletedAirportsAsync();
        }
        catch
        {
            return BadRequest();
        }

        return PartialView("_DeletedAirportsPartial", deletedAirports);
    }
}