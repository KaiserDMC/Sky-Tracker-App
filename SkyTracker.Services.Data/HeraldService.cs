using SkyTracker.Data.Models;
using SkyTracker.Web.ViewModels.Flight;
using SkyTracker.Web.ViewModels.Herald.Enums;

namespace SkyTracker.Services.Data;

using System.Globalization;
using Microsoft.EntityFrameworkCore;

using SkyTracker.Data;
using Interfaces;
using Web.ViewModels.Herald;


public class HeraldService : IHeraldService
{
    private readonly SkyTrackerDbContext _dbContext;

    public HeraldService(SkyTrackerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsAsync()
    {
        var heralds = await _dbContext.HeraldPosts
            .Where(x => x.IsDeleted == false)
            .OrderByDescending(x => x.Occurrence)
            .Select(x => new HeraldAllViewModel
            {
                OccurrenceId = x.Id.ToString(),
                OccurrenceDate = x.Occurrence.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                TypeOccurence = x.TypeOccurence,
                Details = x.Details,
            })
            .ToListAsync();

        return heralds;
    }

    public async Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsSortedByDateAscAsync()
    {
        var heralds = await _dbContext.HeraldPosts
            .Where(x => x.IsDeleted == false)
            .OrderBy(x => x.Occurrence)
            .Select(x => new HeraldAllViewModel
            {
                OccurrenceId = x.Id.ToString(),
                OccurrenceDate = x.Occurrence.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                TypeOccurence = x.TypeOccurence,
                Details = x.Details,
            })
            .ToListAsync();

        return heralds;
    }

    public async Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsSortedByTypeAscAsync()
    {
        var heraldsByTypeAsc = await _dbContext.HeraldPosts
            .Where(x => x.IsDeleted == false)
             .Select(x => new HeraldAllViewModel
             {
                 OccurrenceId = x.Id.ToString(),
                 OccurrenceDate = x.Occurrence.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                 TypeOccurence = x.TypeOccurence,
                 Details = x.Details,
             })
            .OrderBy(x => x.TypeOccurence)
            .ToListAsync();

        return heraldsByTypeAsc;
    }

    public async Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsSortedByTypeDescAsync()
    {
        var heraldsByTypeDesc = await _dbContext.HeraldPosts
            .Where(x => x.IsDeleted == false)
            .Select(x => new HeraldAllViewModel
            {
                OccurrenceId = x.Id.ToString(),
                OccurrenceDate = x.Occurrence.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                TypeOccurence = x.TypeOccurence,
                Details = x.Details,
            })
            .OrderByDescending(x => x.TypeOccurence)
            .ToListAsync();

        return heraldsByTypeDesc;
    }

    public async Task<HeraldDetailsViewModel> GetDetailsById(string occurrenceId)
    {
        var occurrence = await _dbContext.HeraldPosts
            .Where(x => x.Id.ToString() == occurrenceId && x.IsDeleted == false)
            .Select(x => new HeraldDetailsViewModel
            {
                OccurrenceId = x.Id.ToString(),
                OccurrenceDate = x.Occurrence.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                TypeOccurence = x.TypeOccurence,
                Details = x.Details,
                AircraftId = x.AircraftId == null ? null : x.AircraftId.ToString()
            })
            .FirstOrDefaultAsync();

        return occurrence;
    }

    public async Task<IEnumerable<HeraldTypeModel>> GetHeraldTypeAsync()
    {
        var heraldTypes = Enum.GetValues(typeof(HeraldType))
            .Cast<HeraldType>()
            .Select(x => new HeraldTypeModel
            {
                Id = (int)x,
                Type = x,
                Name = x.ToString()
            })
            .ToList();

        return heraldTypes;
    }

    public async Task<IEnumerable<AircraftCollectionViewModel>> GetAircraftForHerald()
    {
        var aircraftCollection = await _dbContext.Aircraft
            .Where(x => x.IsDeleted == false)
            .Select(x => new AircraftCollectionViewModel
            {
                Id = x.Id.ToString(),
                Registration = x.Registration
            })
            .ToListAsync();

        return aircraftCollection;
    }

    public async Task AddHeraldAsync(HeraldFormModel model)
    {
        if (_dbContext.HeraldPosts.Where(f=>f.Id == model.Id).Any())
        {
            model.Error = "Herald Post already exists.";
            return;
        }

        HeraldPost herald = new HeraldPost()
        {
            Id = model.Id,
            Occurrence = model.Occurrence,
            TypeOccurence = model.TypeOccurrence,
            Details = model.Details,
            AircraftId = model.AircraftId == null ? null : model.AircraftId.ToString()
        };

        if (herald.AircraftId != null && herald.TypeOccurence == "Crash")
        {
            var aircraft = await _dbContext.Aircraft
                .Where(x => x.Id == herald.AircraftId)
                .FirstOrDefaultAsync();

            if (aircraft != null)
            {
                aircraft.IsTotaled = true;
            }
        }

        await _dbContext.HeraldPosts.AddAsync(herald);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<HeraldFormModel> GetHeraldbyIdAsync(string heraldId)
    {
        var heraldById = await _dbContext.HeraldPosts
            .Where(h => h.IsDeleted == false)
            .FirstOrDefaultAsync(h => h.Id.ToString() == heraldId);

        if (heraldById != null)
        {
            HeraldFormModel herald = new HeraldFormModel()
            {
                Id = heraldById.Id,
                Occurrence = heraldById.Occurrence,
                TypeOccurrence = heraldById.TypeOccurence,
                Details = heraldById.Details,
                AircraftId = heraldById.AircraftId
            };

            return herald;
        }

        return null;
    }

    public async Task EditHeraldAsync(string heraldId, HeraldFormModel model)
    {
        var heraldToUpdate = await _dbContext.HeraldPosts
            .Where(h => h.IsDeleted == false)
            .FirstOrDefaultAsync(h => h.Id.ToString() == heraldId);

        if (heraldToUpdate != null)
        {
            heraldToUpdate.Occurrence = model.Occurrence;
            heraldToUpdate.TypeOccurence = model.TypeOccurrence;
            heraldToUpdate.Details = model.Details;
            heraldToUpdate.AircraftId = model.AircraftId;
        }

        if (heraldToUpdate.AircraftId != null && heraldToUpdate.TypeOccurence == "Crash")
        {
            var aircraft = await _dbContext.Aircraft
                .Where(x => x.Id == heraldToUpdate.AircraftId)
                .FirstOrDefaultAsync();

            if (aircraft != null)
            {
                aircraft.IsTotaled = true;
            }
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteHeraldAsync(string[] heraldIds)
    {
        var heraldsToDelete = _dbContext.HeraldPosts
            .Where(h => h.IsDeleted == false)
            .Where(h => heraldIds.Contains(h.Id.ToString()))
            .ToListAsync();

        foreach (var herald in await heraldsToDelete)
        {
            herald.IsDeleted = true;
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<HeraldAllViewModel>> GetDeletedHeraldsAsync()
    {
        var deletedHeralds = await _dbContext.HeraldPosts
            .Where(h => h.IsDeleted == true)
            .OrderByDescending(h=>h.Occurrence)
            .Select(h=> new HeraldAllViewModel()
            {
                OccurrenceId = h.Id.ToString(),
                OccurrenceDate = h.Occurrence.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                TypeOccurence = h.TypeOccurence,
                Details = h.Details
            })
            .ToListAsync();

        return deletedHeralds;
    }
}