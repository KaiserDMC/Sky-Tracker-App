namespace SkyTracker.Services.Data;

using System.Globalization;

using Interfaces;

using Microsoft.EntityFrameworkCore;

using SkyTracker.Data;

using Web.ViewModels.Home;

/// <summary>
/// Home Service used to provide the Home -> Index view with the latest Herald News.
/// </summary>

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