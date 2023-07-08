namespace SkyTracker.Services.Data;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using SkyTracker.Data;
using SkyTracker.Services.Data.Interfaces;
using SkyTracker.Web.ViewModels.Flight;

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
}