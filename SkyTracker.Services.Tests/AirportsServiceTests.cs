namespace SkyTracker.Services.Tests;

using Data;
using Data.Interfaces;

using Microsoft.EntityFrameworkCore;

using SkyTracker.Data;
using SkyTracker.Data.Models;
using Web.ViewModels.Airports;

using static TestDatabaseSeed;

public class AirportsServiceTests
{
    private SkyTrackerDbContext _dbContext;

    private IAirportsService _airportsService;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<SkyTrackerDbContext>()
            .UseInMemoryDatabase(databaseName: "SkyTrackerTestDb")
            .Options;

        this._dbContext = new SkyTrackerDbContext(options);

        this._dbContext.Database.EnsureCreated();

        SeedDatabase(this._dbContext);

        this._airportsService = new AirportsService(this._dbContext);
    }

    [TearDown]
    public void TearDown()
    {
        _dbContext.Database.EnsureDeleted();
    }

    [Test]
    public async Task GetAllAirportsAsync_ShouldWork_ReturnAllAirports()
    {
        var result = await _airportsService.GetAllAirportsAsync();

        Assert.IsNotNull(result);
        Assert.AreEqual(13, result.Count());
    }

    [Test]
    public async Task GetAirportDetailsByIata_ShouldWork_ExistingAirportReturnAirport()
    {
        var runwayId = Guid.Parse("68EEF3A3-EE6D-45D2-81A8-00537FBD219F");

        var airportData = new Airport
        {
            IATA = "AAA",
            CommonName = "Airport A",
            RunwaysAirports = new List<RunwayAirport> {
                new RunwayAirport { RunwayId = runwayId }
            }
        };

        _dbContext.Airports.Add(airportData);
        await _dbContext.SaveChangesAsync();

        var result = await _airportsService.GetAirportDetailsByIata("AAA");

        Assert.IsNotNull(result);
        Assert.AreEqual(airportData.IATA, result.IATA);
        Assert.AreEqual(airportData.CommonName, result.CommonName);
        Assert.AreEqual(airportData.RunwaysAirports
            .FirstOrDefault(ra => ra.RunwayId == runwayId)
            ?.Runway.RunwayDesignatorOne, result.Runway.RunwayDesignatorOne);
    }

    [Test]
    public async Task GetRunwaysCollectionAsync_ShouldWork_ReturnAllRunways()
    {
        var result = await _airportsService.GetRunwaysCollectionAsync();

        Assert.IsNotNull(result);
        Assert.AreEqual(108, result.Count());
    }

    [Test]
    public async Task AddAirportAsync_ShouldWork_AddNewAirport()
    {
        var model = new AirportFormModel
        {
            IATA = "AAA",
            CommonName = "Airport A"
        };

        await _airportsService.AddAirportAsync(model);

        var addedAirport = await _dbContext.Airports.FirstOrDefaultAsync(a => a.IATA == "AAA");

        Assert.IsNotNull(addedAirport);
        Assert.AreEqual(model.IATA, addedAirport.IATA);
        Assert.AreEqual(model.CommonName, addedAirport.CommonName);
    }

    [Test]
    public async Task AddAirportAsync_ShouldThrow_ExistingAirportError()
    {
        var model = new AirportFormModel
        {
            IATA = "AAA",
            CommonName = "Airport A"
        };

        await _airportsService.AddAirportAsync(model);

        await _airportsService.AddAirportAsync(model);

        Assert.AreEqual("Airport with this IATA code already exists.", model.Error);
    }

    [Test]
    public async Task GetAirportbyIataAsync_ShouldWork_ReturnAirportModelForEdit()
    {
        var runwayId = Guid.Parse("68EEF3A3-EE6D-45D2-81A8-00537FBD219F");

        var airportData = new Airport
        {
            IATA = "AAA",
            CommonName = "Airport A",
            IsDeleted = false,
            RunwaysAirports = new List<RunwayAirport> {
                new RunwayAirport { RunwayId = runwayId}
            }
        };

        _dbContext.Airports.Add(airportData);
        await _dbContext.SaveChangesAsync();

        var result = await _airportsService.GetAirportbyIataAsync("AAA");

        Assert.IsNotNull(result);
        Assert.AreEqual(airportData.IATA, result.IATA);
        Assert.AreEqual(airportData.CommonName, result.CommonName);
    }

    [Test]
    public async Task GetAirportbyIataAsync_ShouldThrow_IataIsNull()
    {
        var result = await _airportsService.GetAirportbyIataAsync(null);

        Assert.IsNull(result);
    }

    [Test]
    public async Task GetAirportbyIataAsync_ShouldThrow_IataIsEmpty()
    {
        var result = await _airportsService.GetAirportbyIataAsync(string.Empty);

        Assert.IsNull(result);
    }

    [Test]
    public async Task GetAirportbyIataAsync_ShouldThrow_AirportNotFound()
    {
        var nonExistentIata = "ZZZ";

        var result = await _airportsService.GetAirportbyIataAsync(nonExistentIata);

        Assert.IsNull(result);
    }

    [Test]
    public async Task EditAirportAsync_ShouldWork_UpdateAirport()
    {
        var runwayId = Guid.Parse("68EEF3A3-EE6D-45D2-81A8-00537FBD219F");

        var newIataCode = "NEW";

        var newAirport = new Airport
        {
            IATA = newIataCode,
            ICAO = "XXXX",
            CommonName = "Initial Common Name",
            LocationCity = "Initial City",
            LocationCountry = "Initial Country",
            Lat = "0.0",
            Long = "0.0",
            ImagePathUrl = "https://example.com/initial-image.jpg",
            RunwaysAirports = new List<RunwayAirport> {
                new RunwayAirport { RunwayId = runwayId}
            }
        };
        _dbContext.Airports.Add(newAirport);
        await _dbContext.SaveChangesAsync();

        var model = new AirportFormModel
        {
            IATA = newIataCode,
            ICAO = "WXYZ",
            CommonName = "Initial Common Name",
            LocationCity = "Initial City",
            LocationCountry = "Initial Country",
            Lat = "0.0",
            Long = "0.0",
            ImagePathUrl = "https://example.com/initial-image.jpg",
            RunwayId = "24"
        };

        await _airportsService.EditAirportAsync(newIataCode, model);

        var updatedAirport = await _dbContext.Airports.FirstOrDefaultAsync(a => a.IATA == newIataCode);

        Assert.NotNull(updatedAirport);
        Assert.AreEqual(model.ICAO, updatedAirport.ICAO);
        Assert.AreEqual(model.CommonName, updatedAirport.CommonName);
        Assert.AreEqual(model.Elevation, updatedAirport.Elevation);
        Assert.AreEqual(model.LocationCity, updatedAirport.LocationCity);
        Assert.AreEqual(model.LocationCountry, updatedAirport.LocationCountry);
        Assert.AreEqual(model.Lat, updatedAirport.Lat);
        Assert.AreEqual(model.Long, updatedAirport.Long);
        Assert.AreEqual(model.ImagePathUrl, updatedAirport.ImagePathUrl);
    }

    [Test]
    public async Task DeleteAirportAsync_ShouldWork_DeleteAirport()
    {
        var runwayId = Guid.Parse("68EEF3A3-EE6D-45D2-81A8-00537FBD219F");

        var airportToDelete = new Airport
        {
            IATA = "AAA",
            IsDeleted = false,
            RunwaysAirports = new List<RunwayAirport> {
                new RunwayAirport { RunwayId = runwayId}
            }
        };

        _dbContext.Airports.Add(airportToDelete);
        await _dbContext.SaveChangesAsync();

        var iataCodesToDelete = new string[] { "AAA" };

        await _airportsService.DeleteAirportAsync(iataCodesToDelete);

        var deletedAirport = await _dbContext.Airports
            .FirstOrDefaultAsync(a => a.IATA == "AAA");

        Assert.IsNotNull(deletedAirport);
        Assert.IsTrue(deletedAirport.IsDeleted);

        var deletedRunwayAirport = await _dbContext.RunwaysAirports
            .FirstOrDefaultAsync(ra => ra.AirportId == "AAA");

        Assert.IsNull(deletedRunwayAirport);
    }

    [Test]
    public async Task DeleteAirportAsync_ShouldThrow_NonExistingAirportNotDeleted()
    {
        var airportIdsToDelete = new string[] { "AAA", "BBB" };

        await _airportsService.DeleteAirportAsync(airportIdsToDelete);

        Assert.IsFalse(_dbContext.Airports.Any(a => a.IsDeleted));
    }

    [Test]
    public async Task GetDeletedAirportsAsync_ShouldWork_ReturnDeletedAirports()
    {
        var deletedAirports = new List<Airport>
        {
            new Airport { IATA = "AAA", IsDeleted = true },
            new Airport { IATA = "BBB", IsDeleted = true }
        };

        _dbContext.Airports.AddRange(deletedAirports);
        await _dbContext.SaveChangesAsync();

        var result = await _airportsService.GetDeletedAirportsAsync();


        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Count());
        CollectionAssert.AreEqual(deletedAirports.Select(a => a.IATA), result.Select(a => a.IATA));
    }
}