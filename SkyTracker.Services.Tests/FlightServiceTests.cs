using SkyTracker.Data.Models;
using SkyTracker.Web.ViewModels.Flight;

namespace SkyTracker.Services.Tests;

using Data;
using Data.Interfaces;

using Microsoft.EntityFrameworkCore;

using SkyTracker.Data;

using static TestDatabaseSeed;

public class FlightServiceTests
{
    private DbContextOptions<SkyTrackerDbContext> _dbContextOptions;
    private SkyTrackerDbContext _dbContext;

    private IFlightService _flightService;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<SkyTrackerDbContext>()
            .UseInMemoryDatabase(databaseName: "SkyTrackerTestDb")
            .Options;

        this._dbContext = new SkyTrackerDbContext(options);

        this._dbContext.Database.EnsureCreated();

        SeedDatabase(this._dbContext);

        this._flightService = new FlightService(this._dbContext);
    }

    [TearDown]
    public void TearDown()
    {
        _dbContext.Database.EnsureDeleted();
    }

    [Test]
    public async Task GetAllFlightsAsync_ShouldWork_ReturnAllFlightsAscId()
    {
        var result = await _flightService.GetAllFlightsAsync();

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());

        var sortedByFlightIdAscending = result.OrderBy(x => x.FlightId);
        Assert.IsTrue(result.SequenceEqual(sortedByFlightIdAscending));
        Assert.AreEqual(100, result.Count());
    }

    [Test]
    public async Task GetAllFlightsSortedByFlightIdDescAsync_ShouldWork_ReturnFlightsDescId()
    {
        var result = await _flightService.GetAllFlightsSortedByFlightIdDescAsync();

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());

        var sortedByFlightIdDescending = result.OrderByDescending(x => x.FlightId);
        Assert.IsTrue(result.SequenceEqual(sortedByFlightIdDescending));
        Assert.AreEqual(100, result.Count());
    }

    [Test]
    public async Task GetAllFlightsSortedByArpAscAsync_ShouldWork_ReturnFlightsByArpAsc()
    {
        var result = await _flightService.GetAllFlightsSortedByArpAscAsync();

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());

        var sortedByArpAscending = result.OrderBy(x => x.DepartureId);
        Assert.IsTrue(result.SequenceEqual(sortedByArpAscending));
        Assert.AreEqual(100, result.Count());
    }

    [Test]
    public async Task GetAllFlightsSortedByArpDescAsync_ShouldWork_ReturnFlightsByArpDesc()
    {
        var result = await _flightService.GetAllFlightsSortedByArpDescAsync();

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());

        var sortedByArpDescending = result.OrderByDescending(x => x.DepartureId);
        Assert.IsTrue(result.SequenceEqual(sortedByArpDescending));
        Assert.AreEqual(100, result.Count());
    }

    [Test]
    public async Task GetFlightDetailsByIdAsync_ShouldWork_ReturnFlightDetailsViewModel()
    {
        var existingFlight = await _dbContext.Flights.FirstOrDefaultAsync();

        var result = await _flightService.GetFlightDetailsByIdAsync(existingFlight.FlightId);

        Assert.NotNull(result);

        Assert.AreEqual(existingFlight.FlightId, result.FlightId);
        Assert.AreEqual(existingFlight.DepartureId, result.DepartureId);
        Assert.AreEqual(existingFlight.Registration, result.Registration);
        Assert.AreEqual(existingFlight.Equipment, result.Equipment);
        Assert.AreEqual(existingFlight.Callsign, result.Callsign);
        Assert.AreEqual(existingFlight.FlightNumber, result.FlightNumber);
    }

    [Test]
    public async Task GetAirportsCollectionAsync_ShouldWork_ReturnAirportCollectionViewModel()
    {
        var result = await _flightService.GetAirportsCollectionAsync();

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(13, result.Count());
    }

    [Test]
    public async Task GetAircraftsCollectionAsync_ShouldWork_ReturnAircraftCollectionViewModel()
    {
       var result = await _flightService.GetAircraftsCollectionAsync();

       Assert.NotNull(result);
       Assert.IsTrue(result.Any());
       Assert.AreEqual(5, result.Count());
    }

    [Test]
    public async Task AddFlightAsync_ShouldWork_AddNewFlight()
    {
        var newFlightModel = new FlightFormModel
        {
            FlightId = "11111111",
            Callsign = "TestCallsign",
            DepartureId = "ANC",
            Registration = "CGPEV"
        };

        await _flightService.AddFlightAsync(newFlightModel);

        var addedFlight = await _dbContext.Flights.FirstOrDefaultAsync(f => f.FlightId == newFlightModel.FlightId);
        
        Assert.NotNull(addedFlight);
        Assert.AreEqual(newFlightModel.FlightId, addedFlight.FlightId);
        Assert.AreEqual(newFlightModel.Callsign, addedFlight.Callsign);
        Assert.AreEqual(newFlightModel.DepartureId, addedFlight.DepartureId);
        Assert.AreEqual(newFlightModel.Registration, addedFlight.Registration);
    }

    [Test]
    public async Task AddFlightAsync_ShouldThrow_ExistingFlightModelError()
    {
        var existingFlightId = "679614404";

        var modelWithExistingFlightId = new FlightFormModel
        {
            FlightId = existingFlightId,
            Callsign = "TestCallsign",
            DepartureId = "ANC",
            Registration = "CGPEV"
        };
        
        await _flightService.AddFlightAsync(modelWithExistingFlightId);

        Assert.AreEqual("Flight already exists.", modelWithExistingFlightId.Error);
    }

    [Test]
    public async Task GetFlightbyIdAsync_ShouldWork_ReturnFlight()
    {
        var testFlight = await _dbContext.Flights.FirstOrDefaultAsync();

        var result = await _flightService.GetFlightbyIdAsync(testFlight.FlightId);

        Assert.NotNull(result);
        
        Assert.AreEqual(testFlight.DepartureId, result.DepartureId);
        Assert.AreEqual(testFlight.Registration, result.Registration);
        Assert.AreEqual(testFlight.Callsign, result.Callsign);
    }

    [Test]
    public async Task EditFlightAsync_ShouldWork_UpdateFlight()
    {
        var testFlight = await _dbContext.Flights.FirstOrDefaultAsync();

        var updatedFlightModel = new FlightFormModel
        {
            DepartureId = "ANC",
            Registration = "N269TD"
        };

        await _flightService.EditFlightAsync(testFlight.FlightId, updatedFlightModel);

        var updatedFlight = await _dbContext.Flights.FirstOrDefaultAsync(f => f.FlightId == testFlight.FlightId);

        Assert.NotNull(updatedFlight); 
        Assert.AreEqual(testFlight.FlightId, updatedFlight.FlightId);
        Assert.AreEqual(updatedFlightModel.DepartureId, updatedFlight.DepartureId);
    }

    [Test]
    public async Task DeleteFlightAsync_ShouldWork_MarkFlightsAsDeleted()
    {
        var existingFlights = await _dbContext.Flights.Take(2).ToListAsync();

        var flightIdsToDelete = existingFlights.Select(f => f.FlightId).ToArray();

        await _flightService.DeleteFlightAsync(flightIdsToDelete);

        var deletedFlights = await _dbContext.Flights.Where(f => flightIdsToDelete.Contains(f.FlightId) && f.IsDeleted).ToListAsync();

        Assert.AreEqual(flightIdsToDelete.Length, deletedFlights.Count);
    }

    [Test]
    public async Task DeleteFlightAsync_ShouldThrow_NonExistingFlightNotDeleted()
    {
        var flightIdsToDelete = new string[] { "11111111", "22222222" };

        await _flightService.DeleteFlightAsync(flightIdsToDelete);

        Assert.IsFalse(_dbContext.Flights.Any(a => a.IsDeleted));
    }

    [Test]
    public async Task GetDeletedFlightsAsync_ShouldWork_ReturnDeletedFlightsCollection()
    {
        var existingFlights = await _dbContext.Flights.Take(2).ToListAsync();

        var flightIdsToDelete = existingFlights.Select(f => f.FlightId).ToArray();

        await _flightService.DeleteFlightAsync(flightIdsToDelete);

        var result = await _flightService.GetDeletedFlightsAsync();

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(flightIdsToDelete.Length, result.Count());
    }
}