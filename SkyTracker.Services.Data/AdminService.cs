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

    public async Task<IEnumerable<AirportCollectionViewModel>> GetAirportsCollectionAsync()
    {
        var airports = await _dbContext.Airports
            .Where(a => a.IsDeleted == false)
            .Select(a => new AirportCollectionViewModel()
            {
                Id = a.IATA,
                NameIATA = a.IATA,
            })
            .ToListAsync();

        return airports;
    }

    public async Task AddFlightAsync(FlightFormModel model)
    {
        if (_dbContext.Flights.Where(f => f.FlightId == model.FlightId).Any())
        {
            model.Error = "Flight already exists.";
            return;
        }

        Flight flight = new Flight()
        {
            FlightId = model.FlightId,
            Registration = model.Registration,
            Equipment = model.Equipment,
            Callsign = model.Callsign,
            FlightNumber = model.FlightNumber,
            DepartureId = model.DepartureId,
            ScheduledArrival = model.ScheduledArrival,
            RealArrival = model.RealArrival,
            Reserved = model.Reserved
        };

        await _dbContext.Flights.AddAsync(flight);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<FlightFormModel> GetFlightbyIdAsync(string flightId)
    {
        var flightById = await _dbContext.Flights
            .Where(f => f.IsDeleted == false)
            .FirstOrDefaultAsync(f => f.FlightId == flightId);

        if (flightById != null)
        {
            FlightFormModel flight = new FlightFormModel()
            {
                Registration = flightById.Registration,
                Equipment = flightById.Equipment,
                Callsign = flightById.Callsign,
                FlightNumber = flightById.FlightNumber,
                DepartureId = flightById.DepartureId,
                ScheduledArrival = flightById.ScheduledArrival,
                RealArrival = flightById.RealArrival,
                Reserved = flightById.Reserved
            };

            return flight;
        }

        return null;
    }

    public async Task EditFlightAsync(string flightId, FlightFormModel model)
    {
        var flightToUpdate = await _dbContext.Flights
            .Where(f => f.IsDeleted == false)
            .FirstOrDefaultAsync(f => f.FlightId == flightId);

        if (flightToUpdate != null)
        {
            flightToUpdate.Registration = model.Registration;
            flightToUpdate.Equipment = model.Equipment;
            flightToUpdate.Callsign = model.Callsign;
            flightToUpdate.FlightNumber = model.FlightNumber;
            flightToUpdate.DepartureId = model.DepartureId;
            flightToUpdate.ScheduledArrival = model.ScheduledArrival;
            flightToUpdate.RealArrival = model.RealArrival;
            flightToUpdate.Reserved = model.Reserved;
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteFlightAsync(string[] flightIds)
    {
        var flightsToDelete = await _dbContext.Flights
            .Where(f => f.IsDeleted == false)
            .Where(f => flightIds.Contains(f.FlightId))
            .ToListAsync();

        foreach (var flight in flightsToDelete)
        {
            flight.IsDeleted = true;
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<FlightAllViewModel>> GetDeletedFlightsAsync()
    {
        var deletedFlights = await _dbContext.Flights
            .Where(f => f.IsDeleted == true)
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

        return deletedFlights;
    }
}