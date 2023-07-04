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
            .Select(x => new HeraldAllViewModel
            {
                OccurrenceDate = x.Occurrence,
                TypeOccurence = x.TypeOccurence,
                Details = x.Details,
            })
            .ToListAsync();

        return heralds;
    }

    public async Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsSortedByTypeAscAsync()
    {
        var heraldsByTypeAsc = await _dbContext.HeraldPosts
             .Select(x => new HeraldAllViewModel
             {
                 OccurrenceDate = x.Occurrence,
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
            .Select(x => new HeraldAllViewModel
            {
                OccurrenceDate = x.Occurrence,
                TypeOccurence = x.TypeOccurence,
                Details = x.Details,
            })
            .OrderByDescending(x => x.TypeOccurence)
            .ToListAsync();

        return heraldsByTypeDesc;
    }
}