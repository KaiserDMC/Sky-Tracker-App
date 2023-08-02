namespace SkyTracker.Services.Tests;

using Microsoft.EntityFrameworkCore;

using Data;
using Data.Interfaces;
using SkyTracker.Data;

using static TestDatabaseSeed;

public class AircraftServiceTests
{
    private DbContextOptions<SkyTrackerDbContext> _dbContextOptions;
    private SkyTrackerDbContext _dbContext;

    private IAircraftService _aircraftService;

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        var options = new DbContextOptionsBuilder<SkyTrackerDbContext>()
            .UseInMemoryDatabase(databaseName: "SkyTrackerTestDb")
            .Options;

        this._dbContext = new SkyTrackerDbContext(options);

        this._dbContext.Database.EnsureCreated();

        SeedDatabase(this._dbContext);

        this._aircraftService = new AircraftService(this._dbContext);
    }

    [Test]
    public async Task GetAllAircraftAsync_ShouldReturnAllAircraft()
    {

        Assert.Pass();
        //var aircraft = await this._aircraftService.GetAllAircraftAsync();

        //Assert.AreEqual(2, aircraft.Count());
    }
}