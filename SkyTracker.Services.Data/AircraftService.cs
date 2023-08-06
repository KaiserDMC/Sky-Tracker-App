using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace SkyTracker.Services.Data;

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Interfaces;
using SkyTracker.Data;
using SkyTracker.Data.Models;
using Web.ViewModels.Aircraft;

public class AircraftService : IAircraftService
{
    private readonly SkyTrackerDbContext _dbContext;

    public AircraftService(SkyTrackerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<AircraftAllViewModel>> GetAllAircraftAsync()
    {
        var aircraft = await _dbContext.Aircraft
            .Where(a => a.IsDeleted == false)
            .Select(a => new AircraftAllViewModel
            {
                Id = a.Id,
                Registration = a.Registration,
                Equipment = a.Equipment
            })
            .ToListAsync();

        return aircraft;
    }

    public async Task<AircraftDetailsViewModel> GetAircraftDetailsByIdAsync(string aircraftId)
    {
        var aircraft = await _dbContext.Aircraft
            .Include(a => a.AircraftRelatedHeralds)
            .Where(a => a.IsDeleted == false)
            .FirstOrDefaultAsync(a => a.Id == aircraftId);

        if (aircraft != null)
        {
            var aircraftDetails = new AircraftDetailsViewModel
            {
                Id = aircraft.Id,
                Registration = aircraft.Registration,
                Equipment = aircraft.Equipment,
                IsTotaled = aircraft.IsTotaled,
                Herald = aircraft.AircraftRelatedHeralds
                    .Select(h => h.Id.ToString())
                    .FirstOrDefault()
            };

            return aircraftDetails;
        }

        return null;
    }

    public async Task AddAircraftAsync(AircraftFormModel model)
    {
        if (_dbContext.Aircraft.Where(a => a.Id == model.Id).Any())
        {
            model.Error = "Flight already exists.";
            return;
        }

        Aircraft aircraft = new Aircraft
        {
            Id = model.Id,
            Registration = model.Registration,
            Equipment = model.Equipment,
            ImagePathUrl = model.ImagePathUrl
        };

        _dbContext.Aircraft.Add(aircraft);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<AircraftFormModel> GetAircraftbyIdAsync(string aircraftId)
    {
        var aircraftById = await _dbContext.Aircraft
            .Where(a => a.IsDeleted == false)
            .FirstOrDefaultAsync(a => a.Id == aircraftId);

        if (aircraftById != null)
        {
            AircraftFormModel aircraft = new AircraftFormModel()
            {
                Id = aircraftById.Id,
                Registration = aircraftById.Registration,
                Equipment = aircraftById.Equipment,
                ImagePathUrl = aircraftById.ImagePathUrl,
                IsTotaled = aircraftById.IsTotaled
            };

            return aircraft;
        }

        return null;
    }

    public async Task EditAircraftAsync(string aircraftId, AircraftFormModel model)
    {
        var aircraftToUpdate = await _dbContext.Aircraft
            .Where(a => a.IsDeleted == false)
            .FirstOrDefaultAsync(a => a.Id == aircraftId);

        if (aircraftToUpdate != null)
        {
            aircraftToUpdate.Registration = model.Registration;
            aircraftToUpdate.Equipment = model.Equipment;
            aircraftToUpdate.ImagePathUrl = model.ImagePathUrl;
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<string>> GetAircraftPictureIdsAsync(string[] aircraftIds)
    {
        var aircraftRegistrations = await _dbContext.Aircraft
            .Where(a => a.IsDeleted == false)
            .Where(a => aircraftIds.Contains(a.Id))
            .Select(a => a.Registration)
            .ToListAsync();

        return aircraftRegistrations;
    }

    public async Task DeleteAircraftAsync(string[] aircraftIds)
    {
        var aircraftToDelete = await _dbContext.Aircraft
            .Where(a => a.IsDeleted == false)
            .Where(a => aircraftIds.Contains(a.Id))
            .ToListAsync();

        foreach (var aircraft in aircraftToDelete)
        {
            aircraft.IsDeleted = true;
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<AircraftAllViewModel>> GetDeletedAircraftAsync()
    {
        var aircraft = await _dbContext.Aircraft
            .Where(a => a.IsDeleted == true)
            .Select(a => new AircraftAllViewModel
            {
                Id = a.Id,
                Registration = a.Registration,
                Equipment = a.Equipment
            })
            .ToListAsync();

        return aircraft;
    }

    public async Task RepairAircraftAsync(string[] aircraftIds)
    {
        var aircraftToRepair = await _dbContext.Aircraft
            .Where(a => a.IsTotaled == true)
            .Where(a => aircraftIds.Contains(a.Id))
            .ToListAsync();

        foreach (var aircraft in aircraftToRepair)
        {
            aircraft.IsTotaled = false;
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<AircraftAllViewModel>> GetTotaledAircraftAsync()
    {
        var aircraft = await _dbContext.Aircraft
            .Where(a => a.IsTotaled == true)
            .Select(a => new AircraftAllViewModel
            {
                Id = a.Id,
                Registration = a.Registration,
                Equipment = a.Equipment
            })
            .ToListAsync();

        return aircraft;
    }
}