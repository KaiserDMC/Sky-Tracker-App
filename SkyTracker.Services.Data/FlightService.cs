namespace SkyTracker.Services.Data;

using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Interfaces;
using SkyTracker.Data;
using SkyTracker.Data.Models;
using Web.ViewModels.Flight;

public class FlightService : IFlightService
{
    private readonly SkyTrackerDbContext _dbContext;

    public FlightService(SkyTrackerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<FlightAllViewModel>> GetAllFlightsAsync()
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
                FlightNumber = f.FlightNumber,
                DepartureId = f.DepartureId,
                ScheduledArrival = f.ScheduledArrival,
                RealArrival = f.RealArrival,
                Reserved = f.Reserved
            })
            .ToListAsync();

        return flights;
    }

    public async Task<IEnumerable<FlightAllViewModel>> GetAllFlightsSortedByFlightIdDescAsync()
    {
        var flights = await _dbContext.Flights
           .Where(f => f.IsDeleted == false)
           .OrderByDescending(f => f.FlightId)
           .Select(f => new FlightAllViewModel
           {
               FlightId = f.FlightId,
               Registration = f.Registration,
               Equipment = f.Equipment,
               Callsign = f.Callsign,
               FlightNumber = f.FlightNumber,
               DepartureId = f.DepartureId,
               ScheduledArrival = f.ScheduledArrival,
               RealArrival = f.RealArrival,
               Reserved = f.Reserved
           })
           .ToListAsync();

        return flights;
    }

    public async Task<IEnumerable<FlightAllViewModel>> GetAllFlightsSortedByArpAscAsync()
    {
        var flights = await _dbContext.Flights
           .Where(f => f.IsDeleted == false)
           .OrderBy(f => f.DepartureId)
           .Select(f => new FlightAllViewModel
           {
               FlightId = f.FlightId,
               Registration = f.Registration,
               Equipment = f.Equipment,
               Callsign = f.Callsign,
               FlightNumber = f.FlightNumber,
               DepartureId = f.DepartureId,
               ScheduledArrival = f.ScheduledArrival,
               RealArrival = f.RealArrival,
               Reserved = f.Reserved
           })
           .ToListAsync();

        return flights;
    }

    public async Task<IEnumerable<FlightAllViewModel>> GetAllFlightsSortedByArpDescAsync()
    {
        var flights = await _dbContext.Flights
           .Where(f => f.IsDeleted == false)
           .OrderByDescending(f => f.DepartureId)
           .Select(f => new FlightAllViewModel
           {
               FlightId = f.FlightId,
               Registration = f.Registration,
               Equipment = f.Equipment,
               Callsign = f.Callsign,
               FlightNumber = f.FlightNumber,
               DepartureId = f.DepartureId,
               ScheduledArrival = f.ScheduledArrival,
               RealArrival = f.RealArrival,
               Reserved = f.Reserved
           })
           .ToListAsync();

        return flights;
    }

    public async Task<FlightDetailsViewModel> GetFlightDetailsByIdAsync(string flightId)
    {
        var flight = await _dbContext.Flights
            .Where(f => f.FlightId == flightId && f.IsDeleted == false)
            .Include(a => a.FlightsAircraft)
            .ThenInclude(a => a.Aircraft)
            .FirstOrDefaultAsync();

        var flightDetails = new FlightDetailsViewModel()
        {
            FlightId = flight.FlightId,
            Registration = flight?.Registration,
            Equipment = flight?.Equipment,
            Callsign = flight.Callsign,
            FlightNumber = flight?.FlightNumber,
            DepartureId = flight.DepartureId,
            ScheduledArrival = flight?.ScheduledArrival,
            RealArrival = flight?.RealArrival,
            Reserved = flight?.Reserved,
            Aircraft = flight.FlightsAircraft
                    .Select(ac => ac.Aircraft)
                    .Select(x => new FlightAircraftDetails()
                    {
                        Id = x.Id,
                        ImagePathUrl = Path.GetRelativePath(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"), x.ImagePathUrl)
                    })
                .FirstOrDefault()
        };

        return flightDetails;
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

    public async Task<IEnumerable<AircraftCollectionViewModel>> GetAircraftsCollectionAsync()
    {
        var aircraft = await _dbContext.Aircraft
            .Where(a => a.IsDeleted == false)
            .Select(a => new AircraftCollectionViewModel()
            {
                Id = a.Id,
                Registration = a.Registration,
                Equipment = a.Equipment,
            })
            .ToListAsync();

        return aircraft;
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

        var flightAircraft = new FlightAircraft()
        {
            FlightId = flight.FlightId,
            AircraftId = _dbContext.Aircraft.Where(a => a.Registration == model.Registration).Select(a => a.Id).FirstOrDefault()
        };

        await _dbContext.Flights.AddAsync(flight);
        await _dbContext.FlightsAircraft.AddAsync(flightAircraft);
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

        var currentAircraftFlight = await _dbContext.FlightsAircraft
            .Where(f => f.Flight == flightToUpdate)
            .FirstOrDefaultAsync();

        _dbContext.FlightsAircraft.Remove(currentAircraftFlight);

        var newAircraftFlight = new FlightAircraft()
        {
            FlightId = flightToUpdate.FlightId,
            AircraftId = _dbContext.Aircraft.Where(a => a.Registration == model.Registration).Select(a => a.Id).FirstOrDefault()
        };

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
            flightToUpdate.FlightsAircraft.Add(newAircraftFlight);
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteFlightAsync(string[] flightIds)
    {
        var flightsToDelete = await _dbContext.Flights
            .Where(f => f.IsDeleted == false)
            .Where(f => flightIds.Contains(f.FlightId))
            .Include(f => f.FlightsAircraft)
            .ToListAsync();

        foreach (var flight in flightsToDelete)
        {
            flight.IsDeleted = true;

            var currentAircraftFlight = await _dbContext.FlightsAircraft
                .Where(f => f.Flight == flight)
                .FirstOrDefaultAsync();

            _dbContext.FlightsAircraft.Remove(currentAircraftFlight);
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