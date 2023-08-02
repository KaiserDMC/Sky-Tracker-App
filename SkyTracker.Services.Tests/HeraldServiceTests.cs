﻿namespace SkyTracker.Services.Tests;

using System.Globalization;

using Data;
using Data.Interfaces;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Moq;

using SkyTracker.Data;
using SkyTracker.Data.Models;
using SkyTracker.Web.ViewModels.Herald.Enums;
using SkyTracker.Web.ViewModels.Herald;

public class HeraldServiceTests
{
    private DbContextOptions<SkyTrackerDbContext> _dbContextOptions;
    private SkyTrackerDbContext _dbContext;

    private IHeraldService _heraldService;

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

        this._heraldService = new HeraldService(this._dbContext);
    }

    [TearDown]
    public void TearDown()
    {
        _dbContext.Database.EnsureDeleted();
    }

    [Test]
    public async Task GetAllHeraldsAsync_ShouldWork_ReturnAllHeraldsSortedByDateDesc()
    {
        var result = await _heraldService.GetAllHeraldsAsync();

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        
        var sortedByDateDescending = result.OrderByDescending(x => DateTime.ParseExact(x.OccurrenceDate, "dd-MM-yyyy", CultureInfo.InvariantCulture));
        Assert.IsTrue(result.SequenceEqual(sortedByDateDescending));
        Assert.AreEqual(176, result.Count());
    }

    [Test]
    public async Task GetAllHeraldsSortedByDateAscAsync_ShouldWork_ReturnAllHeraldsSortedByDateAsc()
    {
        var result = await _heraldService.GetAllHeraldsSortedByDateAscAsync();

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        
        var sortedByDateAscending = result.OrderBy(x => DateTime.ParseExact(x.OccurrenceDate, "dd-MM-yyyy", CultureInfo.InvariantCulture)).ToList();
        Assert.IsTrue(result.SequenceEqual(sortedByDateAscending));
        Assert.AreEqual(176, result.Count());
    }

    [Test]
    public async Task GetAllHeraldsSortedByTypeAscAsync_ShouldWork_ReturnHeraldsSortedByTypeAscending()
    {
        var result = await _heraldService.GetAllHeraldsSortedByTypeAscAsync();

        Assert.NotNull(result);
        Assert.IsTrue(result.Any()); 

        var sortedByTypeAscending = result.OrderBy(x => x.TypeOccurence);
        Assert.IsTrue(result.SequenceEqual(sortedByTypeAscending));
        Assert.AreEqual(176, result.Count());
    }

    [Test]
    public async Task GetAllHeraldsSortedByTypeDescAsync_ShouldWork_ReturnHeraldsSortedByTypeDescending()
    {
        var result = await _heraldService.GetAllHeraldsSortedByTypeDescAsync();

        Assert.NotNull(result);
        Assert.IsTrue(result.Any()); 

        var sortedByTypeDescending = result.OrderByDescending(x => x.TypeOccurence);
        Assert.IsTrue(result.SequenceEqual(sortedByTypeDescending));
        Assert.AreEqual(176, result.Count());
    }

    [Test]
    public async Task GetDetailsById_ShouldWork_ReturnHeraldDetailsViewModel()
    {
        var existingHerald = await _dbContext.HeraldPosts.FirstOrDefaultAsync();

        var result = await _heraldService.GetDetailsById(existingHerald.Id.ToString());

        Assert.NotNull(result);

        Assert.AreEqual(existingHerald.Id.ToString(), result.OccurrenceId);
        Assert.AreEqual(existingHerald.Occurrence.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture), result.OccurrenceDate);
        Assert.AreEqual(existingHerald.TypeOccurence, result.TypeOccurence);
        Assert.AreEqual(existingHerald.Details, result.Details);
    }

    [Test]
    public async Task GetHeraldTypeAsync_ShouldWork_ReturnHeraldTypeModelList()
    {

        var result = await _heraldService.GetHeraldTypeAsync();

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(5, result.Count());
    }

    [Test]
    public async Task AddHeraldAsync_ShouldWork_AddNewHerald()
    {
        var model = new HeraldFormModel
        {
            Id = Guid.NewGuid(),
            Occurrence = DateTime.UtcNow,
            TypeOccurrence = HeraldType.Incident.ToString(),
            Details = "Test details"
        };

        await _heraldService.AddHeraldAsync(model);

        Assert.IsNull(model.Error);

        var addedHerald = await _dbContext.HeraldPosts.FirstOrDefaultAsync(h => h.Id == model.Id);

        Assert.NotNull(addedHerald);

        Assert.AreEqual(model.Id, addedHerald.Id);
        Assert.AreEqual(model.Occurrence, addedHerald.Occurrence);
        Assert.AreEqual(model.TypeOccurrence, addedHerald.TypeOccurence);
        Assert.AreEqual(model.Details, addedHerald.Details);
    }

    [Test]
    public async Task AddHeraldAsync_ShouldThrow_ExistingHeraldModelError()
    {
        var model = new HeraldFormModel
        {
            Id = Guid.NewGuid(),
            Occurrence = DateTime.UtcNow,
            TypeOccurrence = HeraldType.Incident.ToString(),
            Details = "Test details"
        };

        await _heraldService.AddHeraldAsync(model);

        Assert.IsNull(model.Error);

        var addedHerald = await _dbContext.HeraldPosts.FirstOrDefaultAsync(h => h.Id == model.Id);

        Assert.NotNull(addedHerald);

        Assert.AreEqual(model.Id, addedHerald.Id);
        Assert.AreEqual(model.Occurrence, addedHerald.Occurrence);
        Assert.AreEqual(model.TypeOccurrence, addedHerald.TypeOccurence);
        Assert.AreEqual(model.Details, addedHerald.Details);

        await _heraldService.AddHeraldAsync(model);

        Assert.NotNull(model.Error);
        Assert.AreEqual("Herald Post already exists.", model.Error);
    }

    [Test]
    public async Task GetHeraldbyIdAsync_ShouldWork_ReturnHeraldFormModel()
    {
        var existingHerald = await _dbContext.HeraldPosts.FirstOrDefaultAsync();

        var result = await _heraldService.GetHeraldbyIdAsync(existingHerald.Id.ToString());

        Assert.NotNull(result);

        Assert.AreEqual(existingHerald.Id, result.Id);
        Assert.AreEqual(existingHerald.Occurrence, result.Occurrence);
        Assert.AreEqual(existingHerald.TypeOccurence, result.TypeOccurrence);
        Assert.AreEqual(existingHerald.Details, result.Details);
    }

    [Test]
    public async Task EditHeraldAsync_ShouldWork_UpdateHerald()
    {
        var existingHerald = await _dbContext.HeraldPosts.FirstOrDefaultAsync();

        var updatedModel = new HeraldFormModel
        {
            Id = existingHerald.Id,
            Occurrence = DateTime.UtcNow,
            TypeOccurrence = HeraldType.Accident.ToString(),
            Details = "Updated details"
        };

        await _heraldService.EditHeraldAsync(existingHerald.Id.ToString(), updatedModel);


        var updatedHerald = await _dbContext.HeraldPosts.FirstOrDefaultAsync(h => h.Id == existingHerald.Id);
        Assert.NotNull(updatedHerald);

        Assert.AreEqual(updatedModel.Occurrence, updatedHerald.Occurrence);
        Assert.AreEqual(updatedModel.TypeOccurrence, updatedHerald.TypeOccurence);
        Assert.AreEqual(updatedModel.Details, updatedHerald.Details);
    }

    [Test]
    public async Task DeleteHeraldAsync_ShouldWork_MarkHeraldsAsDeleted()
    {
        var existingHeralds = await _dbContext.HeraldPosts.Take(2).ToListAsync();

        var heraldIdsToDelete = existingHeralds.Select(h => h.Id.ToString()).ToArray();

        await _heraldService.DeleteHeraldAsync(heraldIdsToDelete);

        foreach (var herald in existingHeralds)
        {
            var deletedHerald = await _dbContext.HeraldPosts.FirstOrDefaultAsync(h => h.Id == herald.Id);
            Assert.NotNull(deletedHerald);
            Assert.IsTrue(deletedHerald.IsDeleted);
        }
    }

    [Test]
    public async Task GetDeletedHeraldsAsync_ShouldWork_ReturnDeletedHeraldCollection()
    {
        var existingHeralds = await _dbContext.HeraldPosts.Take(2).ToListAsync();

        var heraldIdsToDelete = existingHeralds.Select(h => h.Id.ToString()).ToArray();

        await _heraldService.DeleteHeraldAsync(heraldIdsToDelete);

        var result = await _heraldService.GetDeletedHeraldsAsync();

        Assert.NotNull(result);
        Assert.IsTrue(result.Any());
        Assert.AreEqual(2, result.Count());
    }
}