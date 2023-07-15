namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Azure.Storage.Blobs;

using Configuration;
using SkyTracker.Services.Data.Interfaces;
using static SkyTracker.Common.GeneralApplicationContants;

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
}