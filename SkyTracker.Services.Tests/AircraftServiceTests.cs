namespace SkyTracker.Services.Tests;

using Data;
using Data.Interfaces;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Moq;

using SkyTracker.Data;
using SkyTracker.Data.Models;
using Web.ViewModels.Aircraft;

public class AircraftServiceTests
{
    private DbContextOptions<SkyTrackerDbContext> _dbContextOptions;
    private SkyTrackerDbContext _dbContext;

    private IAircraftService _aircraftService;

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

        this._aircraftService = new AircraftService(this._dbContext);
    }

    [TearDown]
    public void TearDown()
    {
        _dbContext.Database.EnsureDeleted();
    }

    [Test]
    public async Task GetAllAircraftAsync_ShouldWork()
    {

        var aircraft = await this._aircraftService.GetAllAircraftAsync();

        Assert.AreEqual(5, aircraft.Count());
    }

    [Test]
    public async Task GetAircraftDetailsByIdAsync_ShouldWork_ReturnDetails()
    {
        var existingAircraft = new Aircraft
        {
            Id = "11111111",
            Registration = "ABC123",
            Equipment = "Equipment1",
            IsDeleted = false
        };

        _dbContext.Aircraft.Add(existingAircraft);
        await _dbContext.SaveChangesAsync();

        var aircraftDetails = await _aircraftService.GetAircraftDetailsByIdAsync("11111111");

        Assert.IsNotNull(aircraftDetails);
        Assert.AreEqual("11111111", aircraftDetails.Id);
        Assert.AreEqual("ABC123", aircraftDetails.Registration);
        Assert.AreEqual("Equipment1", aircraftDetails.Equipment);
    }

    [Test]
    public async Task GetAircraftDetailsByIdAsync_ShouldThrow_DeletedAircraft_ReturnNull()
    {
        var deletedAircraft = new Aircraft
        {
            Id = "22222222",
            Registration = "XYZ789",
            Equipment = "Equipment2",
            IsDeleted = false
        };

        _dbContext.Aircraft.Add(deletedAircraft);
        await _dbContext.SaveChangesAsync();

        deletedAircraft.IsDeleted = true;
        await _dbContext.SaveChangesAsync();

        var aircraftDetails = await _aircraftService.GetAircraftDetailsByIdAsync("22222222");

        Assert.IsNull(aircraftDetails);
    }

    [Test]
    public async Task GetAircraftDetailsByIdAsync_ShouldThrow_NonExistingAircraft_ReturnNull()
    {
        var aircraftDetails = await _aircraftService.GetAircraftDetailsByIdAsync("33333333");

        Assert.IsNull(aircraftDetails);
    }

    [Test]
    public async Task AddAircraftAsync_ShouldWork_NewAircraftAdded()
    {
        var model = new AircraftFormModel
        {
            Id = "11111111",
            Registration = "ABC123",
            Equipment = "Equipment1"
        };

        await _aircraftService.AddAircraftAsync(model);

        var aircraft = await _dbContext.Aircraft.FirstOrDefaultAsync(a => a.Id == model.Id);
        Assert.NotNull(aircraft);
        Assert.AreEqual(model.Registration, aircraft.Registration);
        Assert.AreEqual(model.Equipment, aircraft.Equipment);
        Assert.AreEqual(model.ImagePathUrl, aircraft.ImagePathUrl);
    }

    [Test]
    public async Task AddAircraftAsync_ShouldThrow_ExistingAircraftError()
    {
        var model = new AircraftFormModel
        {
            Id = "10594670",
            Registration = "N206MP",
            Equipment = "B06"
        };

        await _aircraftService.AddAircraftAsync(model);

        Assert.AreEqual("Flight already exists.", model.Error);
    }

    [Test]
    public async Task GetAircraftByIdAsync_ShouldWork_ReturnAircraft()
    {
        var aircraft = await this._aircraftService.GetAircraftbyIdAsync("10594670");

        Assert.AreEqual("10594670", aircraft.Id);
        Assert.AreEqual("N206MP", aircraft.Registration);
        Assert.AreEqual("B06", aircraft.Equipment);
    }

    [Test]
    public async Task GetAircraftByIdAsync_ShouldThrow_ReturnNull()
    {
        var aircraft = await this._aircraftService.GetAircraftbyIdAsync("1");

        Assert.IsNull(aircraft);
    }

    [Test]
    public async Task EditAircraftAsync_ShouldWork_UpdateExistingAircraft()
    {
        var existingAircraft = new Aircraft
        {
            Id = "11111111",
            Registration = "ABC123",
            Equipment = "Equipment1"
        };

        _dbContext.Aircraft.Add(existingAircraft);
        await _dbContext.SaveChangesAsync();

        var model = new AircraftFormModel
        {
            Registration = "UpdatedReg",
            Equipment = "UpdatedEquipment"
        };

        await _aircraftService.EditAircraftAsync("11111111", model);

        var updatedAircraft = await _dbContext.Aircraft.FirstOrDefaultAsync(a => a.Id == "11111111");

        Assert.IsNotNull(updatedAircraft);
        Assert.AreEqual("UpdatedReg", updatedAircraft.Registration);
        Assert.AreEqual("UpdatedEquipment", updatedAircraft.Equipment);
    }

    [Test]
    public async Task EditAircraftAsync_ShouldThrow_NotUpdateDeletedAircraft()
    {
        var deletedAircraft = new Aircraft
        {
            Id = "22222222",
            Registration = "XYZ789",
            Equipment = "Equipment2"
        };

        _dbContext.Aircraft.Add(deletedAircraft);
        await _dbContext.SaveChangesAsync();

        deletedAircraft.IsDeleted = true;
        await _dbContext.SaveChangesAsync();

        var model = new AircraftFormModel
        {
            Registration = "UpdatedReg",
            Equipment = "UpdatedEquipment"
        };

        await _aircraftService.EditAircraftAsync("22222222", model);

        var updatedAircraft = await _dbContext.Aircraft.FirstOrDefaultAsync(a => a.Id == "22222222");

        Assert.IsNotNull(updatedAircraft);
        Assert.AreEqual("XYZ789", updatedAircraft.Registration);
        Assert.AreEqual("Equipment2", updatedAircraft.Equipment);
    }

    [Test]
    public async Task EditAircraftAsync_ShouldThrow_NotUpdateNonExistingAircraft()
    {
        var model = new AircraftFormModel
        {
            Registration = "UpdatedReg",
            Equipment = "UpdatedEquipment",
        };

        await _aircraftService.EditAircraftAsync("33333333", model);

        var updatedAircraft = await _dbContext.Aircraft.FirstOrDefaultAsync(a => a.Id == "33333333");

        Assert.IsNull(updatedAircraft);
    }

    [Test]
    public async Task GetAircraftPictureIdsAsync_ShouldWork_ReturnIds()
    {
        var existingAircraft = new List<Aircraft>
        {
            new Aircraft { Id = "11111111", Registration = "ABC123", IsDeleted = false },
            new Aircraft { Id = "22222222", Registration = "XYZ789", IsDeleted = false }
        };

        _dbContext.Aircraft.AddRange(existingAircraft);
        await _dbContext.SaveChangesAsync();

        var aircraftIdsToGet = new string[] { "11111111", "22222222" };

        var result = await _aircraftService.GetAircraftPictureIdsAsync(aircraftIdsToGet);

        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Count);
        Assert.Contains("ABC123", result);
        Assert.Contains("XYZ789", result);
    }

    [Test]
    public async Task GetAircraftPictureIdsAsync_ShouldThrow_NonExistingAircraftReturnEmptyCollection()
    {
        var aircraftIdsToGet = new string[] { "11111111", "22222222" };

        var result = await _aircraftService.GetAircraftPictureIdsAsync(aircraftIdsToGet);

        Assert.IsNotNull(result);
        Assert.AreEqual(0, result.Count);
    }

    [Test]
    public async Task DeleteAircraftAsync_ShouldWork_ExistingAircraftDelete()
    {
        var existingAircraft = new List<Aircraft>
        {
            new Aircraft { Id = "11111111", Registration = "ABC123", IsDeleted = false },
            new Aircraft { Id = "22222222", Registration = "XYZ789", IsDeleted = false }
        };

        _dbContext.Aircraft.AddRange(existingAircraft);
        await _dbContext.SaveChangesAsync();

        var aircraftIdsToDelete = new string[] { "11111111", "22222222" };

        await _aircraftService.DeleteAircraftAsync(aircraftIdsToDelete);
        
        Assert.IsTrue(_dbContext.Aircraft.Any(a => a.IsDeleted));
        Assert.AreEqual(2, _aircraftService.GetDeletedAircraftAsync().Result.Count());
    }

    [Test]
    public async Task DeleteAircraftAsync_ShouldThrow_NonExistingAircraftNotDeleted()
    {
       var aircraftIdsToDelete = new string[] { "11111111", "22222222" };

        await _aircraftService.DeleteAircraftAsync(aircraftIdsToDelete);

        Assert.IsFalse(_dbContext.Aircraft.Any(a => a.IsDeleted));
    }

    [Test]
    public async Task GetDeletedAircraft_ShouldWork_ReturnDeletedCollection()
    {
        var deletedAircraft = new Aircraft
        {
            Id = "22222222",
            Registration = "XYZ789",
            Equipment = "Equipment2"
        };

        _dbContext.Aircraft.Add(deletedAircraft);
        await _dbContext.SaveChangesAsync();

        deletedAircraft.IsDeleted = true;
        await _dbContext.SaveChangesAsync();
        
        var aircraft = await this._aircraftService.GetDeletedAircraftAsync();

        Assert.AreEqual(1, aircraft.Count());
        Assert.AreEqual("22222222", aircraft.First().Id);
        Assert.AreEqual("XYZ789", aircraft.First().Registration);
        Assert.AreEqual("Equipment2", aircraft.First().Equipment);
    }
}