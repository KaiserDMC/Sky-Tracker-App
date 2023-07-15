using SkyTracker.Web.Configuration;

namespace SkyTracker.Web.Controllers;

using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using SkyTracker.Services.Data.Interfaces;
using static Common.GeneralApplicationContants;

[Authorize]
public class AirportsController : Controller
{
    private readonly IAirportsService _airportsService;
    private readonly BlobServiceClient _blobServiceClient;
    private readonly IWebHostEnvironment _hostingEnvironment;


    public AirportsController(IAirportsService airportsService, BlobServiceClient blobServiceClient, IWebHostEnvironment hostingEnvironment)
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
}