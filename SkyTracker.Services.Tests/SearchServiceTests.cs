namespace SkyTracker.Services.Tests;

using Data;
using Data.Interfaces;

using Microsoft.EntityFrameworkCore;

using SkyTracker.Data;

using static TestDatabaseSeed;

/// <summary>
/// Search Service Unit Tests using InMemoryDatabase
/// </summary>

public class SearchServiceTests
{
    private SkyTrackerDbContext _dbContext;

    private ISearchService _searchService;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<SkyTrackerDbContext>()
            .UseInMemoryDatabase(databaseName: "SkyTrackerTestDb")
            .Options;

        this._dbContext = new SkyTrackerDbContext(options);

        this._dbContext.Database.EnsureCreated();

        SeedDatabase(this._dbContext);

        this._searchService = new SearchService(this._dbContext);
    }

    [TearDown]
    public void TearDown()
    {
        _dbContext.Database.EnsureDeleted();
    }

    [Test]
    public async Task SearchAircraftAsync_ValidQuery_Id_ShouldReturnResults()
    {
        string query = "10594670";
        string[] properties = { "aircraftId" };

        var result = await _searchService.SearchAircraftAsync(query, properties);

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(1, result.Count());
        Assert.AreEqual(query, result.First().Id);
    }

    [Test]
    public async Task SearchAircraftAsync_ValidQuery_Registration_ShouldReturnResults()
    {
        string query = "CGPEV";
        string[] properties = { "aircraftRegistration" };

        var result = await _searchService.SearchAircraftAsync(query, properties);

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(1, result.Count());
        Assert.AreEqual(query, result.First().Registration);
    }

    [Test]
    public async Task SearchAircraftAsync_ValidQuery_Equipment_ShouldReturnResults()
    {
        string query = "BN2P";
        string[] properties = { "aircraftEquipment" };

        var result = await _searchService.SearchAircraftAsync(query, properties);

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(1, result.Count());
        Assert.AreEqual(query, result.First().Equipment);
    }

    [Test]
    // This test is practically useless as the server would not allow empty queries.
    public async Task SearchAircraftAsync_EmptyQuery_ShouldReturnNull()
    {
        string query = "";
        string[] properties = { "aircraftRegistration" };

        var result = await _searchService.SearchAircraftAsync(query, properties);

        Assert.IsNull(result);
    }

    [Test]
    public async Task SearchAircraftAsync_InvalidQuery_ShouldReturnEmpty()
    {
        string query = "InvalidQuery";
        string[] properties = { "aircraftRegistration" };

        var result = await _searchService.SearchAircraftAsync(query, properties);

        Assert.IsEmpty(result);
    }

    [Test]
    public async Task SearchAirportsAsync_ValidQuery_Iata_ShouldReturnResults()
    {
        string query = "ENA";
        string[] properties = { "airportIata" };

        var result = await _searchService.SearchAirportsAsync(query, properties);

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(1, result.Count());
        Assert.AreEqual(query, result.First().IATA);
    }

    [Test]
    public async Task SearchAirportsAsync_ValidQuery_Icao_ShouldReturnResults()
    {
        string query = "PAEN";
        string[] properties = { "airportIcao" };

        var result = await _searchService.SearchAirportsAsync(query, properties);

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(1, result.Count());
        Assert.AreEqual(query, result.First().ICAO);
    }

    [Test]
    public async Task SearchAirportsAsync_ValidQuery_Name_ShouldReturnResults()
    {
        string query = "Kenai";
        string[] properties = { "airportName" };

        var result = await _searchService.SearchAirportsAsync(query, properties);

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(1, result.Count());
        Assert.AreEqual("Kenai Municipal Airport", result.First().CommonName);
    }

    [Test]
    public async Task SearchAirportsAsync_ValidQuery_City_ShouldReturnResults()
    {
        string query = "Kenai";
        string[] properties = { "airportCity" };

        var result = await _searchService.SearchAirportsAsync(query, properties);

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(1, result.Count());
        Assert.AreEqual(query, result.First().LocationCity);
    }

    [Test]
    public async Task SearchAirportsAsync_ValidQuery_Country_ShouldReturnResults()
    {
        string query = "United States";
        string[] properties = { "airportCountry" };

        var result = await _searchService.SearchAirportsAsync(query, properties);

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(7, result.Count());
        Assert.AreEqual(query, result.First().LocationCountry);
    }

    [Test]
    // This test is practically useless as the server would not allow empty queries.
    public async Task SearchAirportsAsync_EmptyQuery_ShouldReturnNull()
    {
        string query = "";
        string[] properties = { "airportIata" };

        var result = await _searchService.SearchAirportsAsync(query, properties);

        Assert.IsNull(result);
    }

    [Test]
    public async Task SearchAirportsAsync_InvalidQuery_ShouldReturnEmpty()
    {
        string query = "InvalidQuery";
        string[] properties = { "airportIata" };

        var result = await _searchService.SearchAirportsAsync(query, properties);

        Assert.IsEmpty(result);
    }

    [Test]
    public async Task SearchFlightsAsync_ValidQuery_Id_ShouldReturnResults()
    {
        string query = "679707362";
        string[] properties = { "flightId" };

        var result = await _searchService.SearchFlightsAsync(query, properties);

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(1, result.Count());
        Assert.AreEqual(query, result.First().FlightId);
    }

    [Test]
    public async Task SearchFlightsAsync_ValidQuery_Registration_ShouldReturnResults()
    {
        string query = "N409WB";
        string[] properties = { "flightRegistration" };

        var result = await _searchService.SearchFlightsAsync(query, properties);

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(19, result.Count());
        Assert.AreEqual(query, result.First().Registration);
    }

    [Test]
    public async Task SearchFlightsAsync_ValidQuery_Id_ShouldReturnNoResults()
    {
        string query = "0000000";
        string[] properties = { "flightId" };

        var result = await _searchService.SearchFlightsAsync(query, properties);

        Assert.IsEmpty(result);
        Assert.IsFalse(result.Any());
    }

    [Test]
    // This test is practically useless as the server would not allow empty queries.
    public async Task SearchFlightsAsync_EmptyQuery_ShouldReturnNull()
    {
        string query = string.Empty;
        string[] properties = { };

        var result = await _searchService.SearchFlightsAsync(query, properties);

        Assert.IsNull(result);
    }

    [Test]
    public async Task SearchFlightsAsync_InvalidQuery_ShouldReturnEmpty()
    {
        string query = "InvalidQuery";
        string[] properties = { "flightId" };

        var result = await _searchService.SearchFlightsAsync(query, properties);

        Assert.IsEmpty(result);
    }
}