using SkyTracker.Common;
using SkyTracker.Data.Models;

namespace SkyTracker.Services.Data;

using Microsoft.EntityFrameworkCore;
using System.Globalization;

using Web.ViewModels.Aircraft;
using Web.ViewModels.Airports;
using Web.ViewModels.Herald;
using Web.ViewModels.User;
using Web.ViewModels.Flight;
using Interfaces;
using SkyTracker.Data;

public class AdminService : IAdminService
{
    private readonly SkyTrackerDbContext _dbContext;

    public AdminService(SkyTrackerDbContext dbContext)
    {
        _dbContext = dbContext;
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
                Equipment = a.Equipment,
                ImageUrl = Path.GetRelativePath(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"), a.ImagePathUrl)
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
                LocationCountry = a.LocationCountry,
                ImageUrl = Path.GetRelativePath(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"), a.ImagePathUrl)
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
            .Select(u => new UserViewModel()
            {
                Id = u.Id,
                Username = u.UserName,
                Email = u.Email,
                PhoneNumber = u.PhoneNumber,
            })
            .ToListAsync();

        return users;
    }
}