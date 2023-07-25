using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace SkyTracker.Services.Data;

using Interfaces;
using SkyTracker.Data;
using Web.ViewModels.Home;

public class HomeService : IHomeService
{
    private readonly SkyTrackerDbContext _dbContext;

    public HomeService(SkyTrackerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<HeraldNewsModel>> GetLatestHeraldNewsAsync()
    {
        var heraldNews = await _dbContext.HeraldPosts
            .OrderByDescending(x => x.Occurrence)
            .Take(10)
            .Select(x => new HeraldNewsModel
            {
                OccurrenceId = x.Id.ToString(),
                OccurrenceDate = x.Occurrence.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                TypeOccurence = x.TypeOccurence
            })
            .ToListAsync();

        return heraldNews;
    }
}