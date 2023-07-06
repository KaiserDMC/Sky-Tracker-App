namespace SkyTracker.Services.Data;

using System.Collections.Generic;
using System.Threading.Tasks;

using Interfaces;

using Microsoft.EntityFrameworkCore;

using SkyTracker.Data;
using SkyTracker.Web.ViewModels.Aircraft;

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
                Equipment = a.Equipment,
                ImageUrl = Path.GetRelativePath(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"), a.ImagePathUrl)
            })
            .ToListAsync();

        return aircraft;
    }

    public async Task<AircraftDetailsViewModel> GetAircraftDetailsByIdAsync(string aircraftId)
    {
        var aircraft = await _dbContext.Aircraft
            .Where(a => a.IsDeleted == false)
            .FirstOrDefaultAsync(a => a.Id == aircraftId);

        var aircraftDetails = new AircraftDetailsViewModel
        {
            Id = aircraft.Id,
            Registration = aircraft.Registration,
            Equipment = aircraft.Equipment,
            ImageUrl = Path.GetRelativePath(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"), aircraft.ImagePathUrl)
        };

        return aircraftDetails;
    }

}