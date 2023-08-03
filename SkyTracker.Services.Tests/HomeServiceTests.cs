namespace SkyTracker.Services.Tests;

using System.Globalization;

using Data;
using Data.Interfaces;

using Microsoft.EntityFrameworkCore;

using SkyTracker.Data;

using static TestDatabaseSeed;

public class HomeServiceTests
{
    private DbContextOptions<SkyTrackerDbContext> _dbContextOptions;
    private SkyTrackerDbContext _dbContext;

    private IHomeService _homeService;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<SkyTrackerDbContext>()
            .UseInMemoryDatabase(databaseName: "SkyTrackerTestDb")
            .Options;

        this._dbContext = new SkyTrackerDbContext(options);

        this._dbContext.Database.EnsureCreated();

        SeedDatabase(this._dbContext);

        this._homeService = new HomeService(this._dbContext);
    }

    [TearDown]
    public void TearDown()
    {
        _dbContext.Database.EnsureDeleted();
    }

    [Test]
    public async Task GetLatestHeraldNewsAsync_ShouldWork_ReturnLatestHeraldNews()
    {
        var result = await _homeService.GetLatestHeraldNewsAsync();

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(10, result.Count());

        var sortedByDateDescending = result.OrderByDescending(x => DateTime.ParseExact(x.OccurrenceDate, "dd-MM-yyyy", CultureInfo.InvariantCulture));
        Assert.IsTrue(result.SequenceEqual(sortedByDateDescending));
    }
}