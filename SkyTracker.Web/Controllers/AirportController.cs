namespace SkyTracker.Web.Controllers;

using System.Drawing;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.IO;

using Configuration;
using ViewModels.Airports;
using SkyTracker.Services.Data.Interfaces;
using static Common.GeneralApplicationContants;
using static Configuration.DownloadBlob;
using static Configuration.UploadBlob;

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

    public async Task<IActionResult> All()
    {
        var airports = await _airportsService.GetAllAirportsAsync();

        return View(airports);
    }

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
            return View(model);
        }

        return RedirectToAction("Index", "Admin");
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

        return RedirectToAction("Index", "Admin");
    }

    [HttpPost]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> DeleteAirport(string[] iataCodes)
    {
        try
        {
            await _airportsService.DeleteAirportAsync(iataCodes);
            await ImageHelper.DeleteAirportImages(_hostingEnvironment.WebRootPath, iataCodes);

            return Json(new { success = true });
        }
        catch
        {
            return Json(new { success = true });
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