﻿namespace SkyTracker.Services.Tests;

using Data;
using Data.Interfaces;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Moq;

using SkyTracker.Data;
using SkyTracker.Data.Models;


public class RadarServiceTests
{
    private DbContextOptions<SkyTrackerDbContext> _dbContextOptions;
    private SkyTrackerDbContext _dbContext;

    private IRadarService _radarService;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<SkyTrackerDbContext>()
            .UseInMemoryDatabase(databaseName: "SkyTrackerTestDb")
            .Options;

        this._dbContext = new SkyTrackerDbContext(options);

        this._dbContext.Database.EnsureCreated();

        var userManagerMock = new Mock<TestUserManager>(Mock.Of<IUserStore<ApplicationUser>>(), null, null, null, null, null, null, null, null);

        var testDatabaseSeed = new TestDatabaseSeed(userManagerMock.Object);
        testDatabaseSeed.SeedDatabase(this._dbContext);

        this._radarService = new RadarService(this._dbContext);
    }

    [TearDown]
    public void TearDown()
    {
        _dbContext.Database.EnsureDeleted();
    }

    [Test]
    public async Task GetAirportsGeoDataAsync_ShouldWork_ReturnAirportGeoDataViewModels()
    {
        var result = await _radarService.GetAirportsGeoDataAsync();

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(13, result.Count());
    }

    [Test]
    public async Task GetFlightsForMapAsync_ShouldWork_ReturnFlightViewModels()
    {
        var result = await _radarService.GetFlightsForMapAsync();

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(12, result.Count());
    }

    [Test]
    public async Task GetFlightAndAirportDataAsync_ShouldWork_ReturnFlightAndAirportData()
    {
        var result = await _radarService.GetFlightAndAirportDataAsync();

        Assert.NotNull(result);
        Assert.NotNull(result.Flights);
        Assert.NotNull(result.Airports);

        Assert.IsTrue(result.Flights.Any());
        Assert.AreEqual(12, result.Flights.Count());

        Assert.IsTrue(result.Airports.Any());
        Assert.AreEqual(13, result.Airports.Count());
    }
}