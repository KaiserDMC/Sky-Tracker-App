namespace SkyTracker.Web.Controllers;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using ViewModels.Flight;
using SkyTracker.Services.Data.Interfaces;

using X.PagedList;
using Azure.Storage.Blobs;
using static Common.GeneralApplicationContants;
using static Configuration.DownloadBlob;
using static Configuration.UploadBlob;

[Authorize]
public class FlightController : Controller
{
    private readonly IFlightService _flightService;
    private readonly BlobServiceClient _blobServiceClient;
    private readonly IWebHostEnvironment _hostingEnvironment;

    public FlightController(IFlightService flightService, BlobServiceClient blobServiceClient, IWebHostEnvironment hostingEnvironment)
    {
        _flightService = flightService;
        _blobServiceClient = blobServiceClient;
        _hostingEnvironment = hostingEnvironment;
    }

    public async Task<IActionResult> All(string sortType, int? page, int? pageSize)
    {
        IEnumerable<FlightAllViewModel> flights;

        int pageNumber = page ?? 1;
        int itemsPerPage = pageSize ?? 10;

        switch (sortType)
        {
            case "id_desc":
                flights = await _flightService.GetAllFlightsSortedByFlightIdDescAsync();
                break;
            case "arp_asc":
                flights = await _flightService.GetAllFlightsSortedByArpAscAsync();
                break;
            case "arp_desc":
                flights = await _flightService.GetAllFlightsSortedByArpDescAsync();
                break;
            default:
                flights = await _flightService.GetAllFlightsAsync();
                break;
        }

        var totalItemCount = flights.Count();

        var totalPages = (int)Math.Ceiling((double)totalItemCount / itemsPerPage);
        if (pageNumber > totalPages || itemsPerPage != pageSize)
        {
            pageNumber = 1;
        }

        var pagedFlights = flights.ToPagedList(pageNumber, itemsPerPage);

        var updatedPagedList = new StaticPagedList<FlightAllViewModel>(pagedFlights, pagedFlights.GetMetaData());

        var updatedPagedListWithPageNumber = new StaticPagedList<FlightAllViewModel>(
            updatedPagedList, pageNumber, itemsPerPage, updatedPagedList.TotalItemCount);

        return View(updatedPagedListWithPageNumber);
    }


    public async Task<IActionResult> GetDetailsFlight(string flightId)
    {
        var flight = await _flightService.GetFlightDetailsByIdAsync(flightId);

        BlobContainerClient blobAircraft = _blobServiceClient.GetBlobContainerClient(AircraftImagesContainerName);

        BlobClient blob = blobAircraft.GetBlobClient(flight.Aircraft.Registration?.ToLower() + ".jpg");

        string localPath = Path.Combine(_hostingEnvironment.WebRootPath, AircraftImagesBlobRelativePath, flight.Aircraft.Registration?.ToLower() + ".jpg");

        if (await blob.ExistsAsync())
        {
            await DownloadBlobToFileAsync(blob, localPath);

            flight.Aircraft.ImagePathUrl = Path.Combine(AircraftImagesBlobRelativePath, flight.Aircraft.Registration?.ToLower() + ".jpg");
        }
        else
        {
            blobAircraft = _blobServiceClient.GetBlobContainerClient(StockImagesContainerName);
            blob = blobAircraft.GetBlobClient("stock-aircraft-img" + ".png");
            localPath = Path.Combine(_hostingEnvironment.WebRootPath, StockImagesBlobRelativePath, "stock-aircraft-img" + ".png");

            await DownloadBlobToFileAsync(blob, localPath);

            flight.Aircraft.ImagePathUrl = Path.Combine(StockImagesBlobRelativePath, "stock-aircraft-img" + ".png");
        }

        return View(flight);
    }

    [HttpGet]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> AddFlight()
    {
        var airports = await _flightService.GetAirportsCollectionAsync();
        var aircraft = await _flightService.GetAircraftsCollectionAsync();

        FlightFormModel model = new FlightFormModel()
        {
            AircraftList = aircraft,
            AirportListDeparture = airports,
            AirportListArrival = airports,
            AirportListActual = airports,
            AirporListReserved = airports
        };

        return View(model);
    }

    [HttpPost]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> AddFlight(FlightFormModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        try
        {
            await _flightService.AddFlightAsync(model);
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
    public async Task<IActionResult> EditFlight(string flightId)
    {
        var airports = await _flightService.GetAirportsCollectionAsync();
        var aircraft = await _flightService.GetAircraftsCollectionAsync();

        var flight = await _flightService.GetFlightbyIdAsync(flightId);

        flight.AircraftList = aircraft;
        flight.AirportListDeparture = airports;
        flight.AirportListArrival = airports;
        flight.AirportListActual = airports;
        flight.AirporListReserved = airports;

        return View(flight);
    }

    [HttpPost]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> EditFlight(string flightId, FlightFormModel model)
    {
        var airports = await _flightService.GetAirportsCollectionAsync();
        var aircraft = await _flightService.GetAircraftsCollectionAsync();

        var flight = await _flightService.GetFlightbyIdAsync(flightId);

        flight.AircraftList = aircraft;
        flight.AirportListDeparture = airports;
        flight.AirportListArrival = airports;
        flight.AirportListActual = airports;
        flight.AirporListReserved = airports;

        model.AirportListDeparture = airports;
        model.AirportListArrival = airports;
        model.AirportListActual = airports;
        model.AirporListReserved = airports;

        if (!ModelState.IsValid)
        {
            return View(model);
        }

        flight.Registration = model.Registration;
        flight.Equipment = model.Equipment;
        flight.Callsign = model.Callsign;
        flight.FlightNumber = model.FlightNumber;
        flight.DepartureId = model.DepartureId;
        flight.ScheduledArrival = model.ScheduledArrival;
        flight.RealArrival = model.RealArrival;
        flight.Reserved = model.Reserved;

        try
        {
            await _flightService.EditFlightAsync(flightId, model);
        }
        catch
        {
            return BadRequest();
        }

        return RedirectToAction("Index", "Admin");
    }

    [HttpPost]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> DeleteFlight(string[] flightIds)
    {
        try
        {
            await _flightService.DeleteFlightAsync(flightIds);
            return Json(new { success = true });
        }
        catch
        {
            return Json(new { success = false });
        }
    }

    [HttpGet]
    [Authorize(Roles = "Admin, Moderator")]
    public async Task<IActionResult> DeletedHistoryFlights()
    {
        IEnumerable<FlightAllViewModel> deletedFlights;

        try
        {
            deletedFlights = await _flightService.GetDeletedFlightsAsync();
        }
        catch
        {
            return BadRequest();
        }

        return PartialView("_DeletedFlightsPartial", deletedFlights);
    }
}