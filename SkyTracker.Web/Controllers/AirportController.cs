namespace SkyTracker.Web.Controllers;

using System.Drawing;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

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

        BlobContainerClient blobAirport = _blobServiceClient.GetBlobContainerClient(AirportImagesContainerName);

        BlobClient blob = blobAirport.GetBlobClient(airport.IATA.ToLower() + ".jpg");

        string localPath = Path.Combine(_hostingEnvironment.WebRootPath, AirportImagesBlobRelativePath, airport.IATA.ToLower() + ".jpg");


        if (await blob.ExistsAsync())
        {
            await DownloadBlob.DownloadBlobToFileAsync(blob, localPath);

            airport.ImageUrl = Path.Combine(AirportImagesBlobRelativePath, airport.IATA.ToLower() + ".jpg");
        }
        else
        {
            blobAirport = _blobServiceClient.GetBlobContainerClient(StockImagesContainerName);
            blob = blobAirport.GetBlobClient("stock-airport-img" + ".png");
            localPath = Path.Combine(_hostingEnvironment.WebRootPath, StockImagesBlobRelativePath, "stock-airport-img" + ".png");

            await DownloadBlob.DownloadBlobToFileAsync(blob, localPath);

            airport.ImageUrl = Path.Combine(StockImagesBlobRelativePath, "stock-airport-img" + ".png");
        }

        return View(airport);
    }

    [HttpGet]
    [Authorize(Roles = "Admin")]
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
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> AddAirport(AirportFormModel model)
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
                BlobContainerClient blobAirport = _blobServiceClient.GetBlobContainerClient(StockImagesContainerName);
                BlobClient blob = blobAirport.GetBlobClient("stock-airport-img" + ".png");

                string localPath = Path.Combine(_hostingEnvironment.WebRootPath, StockImagesBlobRelativePath, "stock-airport-img" + ".png");

                await DownloadBlobToFileAsync(blob, localPath);

                model.ImagePathUrl = Path.Combine(StockImagesBlobRelativePath, "stock-airport-img" + ".png");
            }
            else
            {
                BlobContainerClient blobAirport = _blobServiceClient.GetBlobContainerClient(AirportImagesContainerName);

                await UploadFromFileAsync(blobAirport, picturePath);
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
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> EditAirport(string iata)
    {
        var airport = await _airportsService.GetAirportbyIataAsync(iata);

        var runways = await _airportsService.GetRunwaysCollectionAsync();

        airport.Runways = runways;

        BlobContainerClient blobAirport = _blobServiceClient.GetBlobContainerClient(AirportImagesContainerName);
        BlobClient blob = blobAirport.GetBlobClient(airport.IATA.ToLower() + ".jpg");

        if (await blob.ExistsAsync())
        {
            string localPath = Path.Combine(_hostingEnvironment.WebRootPath, AircraftImagesBlobRelativePath, airport.IATA.ToLower() + ".jpg");

            await DownloadBlobToFileAsync(blob, localPath);
            airport.ImagePathUrl = localPath;
        }

        return View(airport);
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
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
            var picturePath = await UploadPicture();

            if (string.IsNullOrEmpty(picturePath))
            {
                BlobContainerClient blobAirport = _blobServiceClient.GetBlobContainerClient(StockImagesContainerName);
                BlobClient blob = blobAirport.GetBlobClient("stock-airport-img" + ".png");

                string localPath = Path.Combine(_hostingEnvironment.WebRootPath, AirportImagesBlobRelativePath,
                    "stock-airport-img" + ".png");

                await DownloadBlobToFileAsync(blob, localPath);

                model.ImagePathUrl = Path.Combine(StockImagesBlobRelativePath, "stock-airport-img" + ".png");
            }
            else
            {
                BlobContainerClient blobAirport = _blobServiceClient.GetBlobContainerClient(AirportImagesContainerName);

                await UploadFromFileAsync(blobAirport, picturePath);
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
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteAirport(string[] iataCodes)
    {
        try
        {
            await _airportsService.DeleteAirportAsync(iataCodes);
            return Json(new { success = true });
        }
        catch
        {
            return Json(new { success = true });
        }
    }

    [HttpGet]
    [Authorize(Roles = "Admin")]
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
        var iata = form["IATA"].ToString().ToLower();
        var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "temp", iata + ".jpg");

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
}