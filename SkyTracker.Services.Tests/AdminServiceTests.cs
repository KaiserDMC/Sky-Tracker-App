namespace SkyTracker.Services.Tests;

using System.Globalization;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Moq;

using SkyTracker.Data;
using SkyTracker.Web.Areas.Admin.Services;
using SkyTracker.Web.Areas.Admin.Services.Interfaces;

using Web.ViewModels.Aircraft;
using Web.ViewModels.Airports;
using Web.ViewModels.Flight;
using Web.ViewModels.Herald;

using static TestDatabaseSeed;


public class AdminServiceTests
{
    private SkyTrackerDbContext _dbContext;

    private IAdminService _adminService;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<SkyTrackerDbContext>()
            .UseInMemoryDatabase(databaseName: "SkyTrackerTestDb")
            .Options;

        this._dbContext = new SkyTrackerDbContext(options);

        this._dbContext.Database.EnsureCreated();

        SeedDatabase(this._dbContext);

        this._adminService = new AdminService(this._dbContext);
    }

    [TearDown]
    public void TearDown()
    {
        _dbContext.Database.EnsureDeleted();
    }

    private Mock<UserManager<TUser>> MockUserManager<TUser>() where TUser : class
    {
        var userStoreMock = new Mock<IUserStore<TUser>>();
        return new Mock<UserManager<TUser>>(userStoreMock.Object, null, null, null, null, null, null, null, null);
    }

    [Test]
    public async Task GetFlightsAsync_ShouldWork_ReturnAllFlights()
    {
        var expected = await this._dbContext.Flights
            .Where(f => f.IsDeleted == false)
            .OrderBy(f => f.FlightId)
            .Select(f => new FlightAllViewModel
            {
                FlightId = f.FlightId,
                Registration = f.Registration,
                Equipment = f.Equipment,
                Callsign = f.Callsign,
                DepartureId = f.DepartureId
            })
            .ToListAsync();

        var actual = await this._adminService.GetFlightsAsync();

        Assert.AreEqual(expected.Count, actual.Count());
        Assert.AreEqual(expected.First().FlightId, actual.First().FlightId);
        Assert.AreEqual(expected.First().Registration, actual.First().Registration);
        Assert.AreEqual(expected.First().Equipment, actual.First().Equipment);
        Assert.AreEqual(expected.First().Callsign, actual.First().Callsign);
        Assert.AreEqual(expected.First().DepartureId, actual.First().DepartureId);
    }

    [Test]
    public async Task GetAircraftAsync_ShouldWork_ReturnAllAircraft()
    {
        var expected = await this._dbContext.Aircraft
            .Where(a => a.IsDeleted == false)
            .Select(a => new AircraftAllViewModel
            {
                Id = a.Id,
                Registration = a.Registration,
                Equipment = a.Equipment
            })
            .ToListAsync();

        var actual = await this._adminService.GetAircraftAsync();

        Assert.AreEqual(expected.Count, actual.Count());
        Assert.AreEqual(expected.First().Id, actual.First().Id);
        Assert.AreEqual(expected.First().Registration, actual.First().Registration);
        Assert.AreEqual(expected.First().Equipment, actual.First().Equipment);
    }

    [Test]
    public async Task GetAirportsAsync_ShouldWork_ReturnAllAirports()
    {
        var expected = await this._dbContext.Airports
            .Where(a => a.IsDeleted == false)
            .OrderBy(a => a.IATA)
            .Select(a => new AirportsAllViewModel
            {
                IATA = a.IATA,
                ICAO = a.ICAO,
                CommonName = a.CommonName,
                Elevation = a.Elevation,
                LocationCity = a.LocationCity,
                LocationCountry = a.LocationCountry
            })
            .ToListAsync();

        var actual = await this._adminService.GetAirportsAsync();

        Assert.AreEqual(expected.Count, actual.Count());
        Assert.AreEqual(expected.First().IATA, actual.First().IATA);
        Assert.AreEqual(expected.First().ICAO, actual.First().ICAO);
        Assert.AreEqual(expected.First().CommonName, actual.First().CommonName);
        Assert.AreEqual(expected.First().Elevation, actual.First().Elevation);
        Assert.AreEqual(expected.First().LocationCity, actual.First().LocationCity);
        Assert.AreEqual(expected.First().LocationCountry, actual.First().LocationCountry);
    }

    [Test]
    public async Task GetHeraldsAsync_ShouldWork_ReturnAllHeralds()
    {
        var expected = await this._dbContext.HeraldPosts
            .Where(h => h.IsDeleted == false)
            .OrderByDescending(h => h.Occurrence)
            .Select(h => new HeraldAllViewModel
            {
                OccurrenceId = h.Id.ToString(),
                OccurrenceDate = h.Occurrence.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                TypeOccurence = h.TypeOccurence,
                Details = h.Details,
            })
            .ToListAsync();

        var actual = await this._adminService.GetHeraldsAsync();

        Assert.AreEqual(expected.Count, actual.Count());
        Assert.AreEqual(expected.First().OccurrenceId, actual.First().OccurrenceId);
        Assert.AreEqual(expected.First().OccurrenceDate, actual.First().OccurrenceDate);
        Assert.AreEqual(expected.First().TypeOccurence, actual.First().TypeOccurence);
        Assert.AreEqual(expected.First().Details, actual.First().Details);
    }
}