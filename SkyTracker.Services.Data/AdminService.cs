namespace SkyTracker.Services.Data;

using System.Globalization;

using Interfaces;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using SkyTracker.Data;
using SkyTracker.Data.Models;

using Web.ViewModels.Aircraft;
using Web.ViewModels.Airports;
using Web.ViewModels.Flight;
using Web.ViewModels.Herald;
using Web.ViewModels.User;

using static SkyTracker.Common.UserRoleNames;

public class AdminService : IAdminService
{
    private readonly SkyTrackerDbContext _dbContext;
    private readonly UserManager<ApplicationUser> _userManager;

    public AdminService(SkyTrackerDbContext dbContext, UserManager<ApplicationUser> userManager)
    {
        _dbContext = dbContext;
        _userManager = userManager;
    }

    public async Task<IEnumerable<FlightAllViewModel>> GetFlightsAsync()
    {
        var flights = await _dbContext.Flights
            .Where(f => f.IsDeleted == false)
            .OrderBy(f => f.FlightId)
            .Select(f => new FlightAllViewModel
            {
                FlightId = f.FlightId,
                Registration = f.Registration,
                Equipment = f.Equipment,
                Callsign = f.Callsign,
                DepartureId = f.DepartureId
            })
            .ToListAsync();

        return flights;
    }

    public async Task<IEnumerable<AircraftAllViewModel>> GetAircraftAsync()
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

    public async Task<IEnumerable<AirportsAllViewModel>> GetAirportsAsync()
    {
        var airports = await _dbContext.Airports
            .Where(a => a.IsDeleted == false)
            .OrderBy(a => a.IATA)
            .Select(a => new AirportsAllViewModel
            {
                IATA = a.IATA,
                ICAO = a.ICAO,
                CommonName = a.CommonName,
                Elevation = a.Elevation,
                LocationCity = a.LocationCity,
                LocationCountry = a.LocationCountry
            })
            .ToListAsync();

        return airports;
    }

    public async Task<IEnumerable<HeraldAllViewModel>> GetHeraldsAsync()
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

    public async Task<IEnumerable<UserViewModel>> GetUsersAsync()
    {
        var users = await _dbContext.Users
            .Where(u => u.IsDeleted == false)
            .OrderBy(u => u.UserName)
            .ToListAsync();

        var nonAdminUsersViewModels = new List<UserViewModel>();

        foreach (var user in users)
        {
            if (!await IsUserInRoleAsync(user, AdminRole))
            {
                nonAdminUsersViewModels.Add(new UserViewModel()
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber
                });
            }
        }

        return nonAdminUsersViewModels;
    }

    private async Task<bool> IsUserInRoleAsync(ApplicationUser user, string role)
    {
        return await _userManager.IsInRoleAsync(user, role);
    }
}