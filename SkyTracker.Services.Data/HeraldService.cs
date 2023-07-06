using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace SkyTracker.Services.Data;

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
        // Retrieve the necessary data based on the occurrence ID and create an OccurrenceViewModel
        var occurrence = await _dbContext.HeraldPosts
            .Where(x => x.Id.ToString() == occurrenceId && x.IsDeleted == false)
            .Select(x => new HeraldDetailsViewModel
            {
                OccurrenceId = x.Id.ToString(),
                OccurrenceDate = x.Occurrence.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                TypeOccurence = x.TypeOccurence,
                Details = x.Details,
            })
            .FirstOrDefaultAsync();

        return occurrence;
    }
}