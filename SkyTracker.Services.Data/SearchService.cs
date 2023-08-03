namespace SkyTracker.Services.Data;

using Microsoft.EntityFrameworkCore;

using Interfaces;
using SkyTracker.Data;
using SkyTracker.Data.Models;

using Web.ViewModels.Aircraft;
using Web.ViewModels.Airports;
using Web.ViewModels.Flight;

public class SearchService : ISearchService
{
    private readonly SkyTrackerDbContext _dbContext;

    public SearchService(SkyTrackerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<AircraftAllViewModel>> SearchAircraftAsync(string query, string[] properties)
    {
        IQueryable<Aircraft> queryable = _dbContext.Aircraft.AsQueryable();

        foreach (string property in properties)
        {
            switch (property)
            {
                case "aircraftId":
                    queryable.Where(a => a.Id == property);
                    break;
                case "aircraftRegistration":
                    queryable.Where(a => a.Registration == property);
                    break;
                case "aircraftEquipment":
                    queryable.Where(a => a.Equipment == property);
                    break;
            }
        }

        if (!string.IsNullOrEmpty(query))
        {
            queryable = queryable.Where(a => a.Registration.Contains(query) || a.Equipment.Contains(query) || a.Id.Contains(query));
        }
        else
        {
            return null;
        }

        return await queryable.Select(a => new AircraftAllViewModel
        {
            Id = a.Id,
            Registration = a.Registration,
            Equipment = a.Equipment
        }).ToListAsync();
    }

    public async Task<IEnumerable<AirportsAllViewModel>> SearchAirportsAsync(string query, string[] properties)
    {
        IQueryable<Airport> queryable = _dbContext.Airports.AsQueryable();

        foreach (string property in properties)
        {
            switch (property)
            {
                case "airportIata":
                    queryable.Where(a => a.IATA == property);
                    break;
                case "airportIcao":
                    queryable.Where(a => a.ICAO == property);
                    break;
                case "airportName":
                    queryable.Where(a => a.CommonName == property);
                    break;
                case "airportCity":
                    queryable.Where(a => a.LocationCity == property);
                    break;
                case "airportCountry":
                    queryable.Where(a => a.LocationCountry == property);
                    break;
            }
        }

        if (!string.IsNullOrEmpty(query))
        {
            queryable = queryable.Where(a => a.IATA.Contains(query) || a.ICAO.Contains(query) || a.CommonName.Contains(query) || a.LocationCity.Contains(query) || a.LocationCountry.Contains(query));
        }
        else
        {
            return null;
        }

        return await queryable.Select(a => new AirportsAllViewModel
        {
            IATA = a.IATA,
            ICAO = a.ICAO,
            CommonName = a.CommonName,
            Elevation = a.Elevation,
            LocationCity = a.LocationCity,
            LocationCountry = a.LocationCountry,
            Lat = a.Lat,
            Long = a.Long,
        }).ToListAsync();
    }

    public async Task<IEnumerable<FlightAllViewModel>> SearchFlightsAsync(string query, string[] properties)
    {
        IQueryable<Flight> queryable = _dbContext.Flights.AsQueryable();

        var separatedQuery = query.Split(' ');

        if (string.IsNullOrEmpty(query) || properties.Length == 0)
        {
            return null;
        }

        foreach (string queryPart in separatedQuery)
        {
            var localQueryPart = queryPart; // Create a local variable for closure
            queryable = queryable.Where(f =>
                f.FlightId.Contains(localQueryPart) ||
                f.Registration.Contains(localQueryPart) ||
                f.Equipment.Contains(localQueryPart) ||
                f.FlightNumber.Contains(localQueryPart) ||
                f.DepartureId.Contains(localQueryPart) ||
                f.ScheduledArrival.Contains(localQueryPart)
            );
        }

        foreach (string property in properties)
        {
            switch (property)
            {
                case "flightId":
                    queryable.Where(a => a.FlightId == property);
                    break;
                case "flightRegistration":
                    queryable.Where(a => a.Registration == property);
                    break;
                case "flightEquipment":
                    queryable.Where(a => a.Equipment == property);
                    break;
                case "flightNumber":
                    queryable.Where(a => a.FlightNumber == property);
                    break;
                case "flightDeparture":
                    queryable.Where(a => a.DepartureId == property);
                    break;
                case "flightArrival":
                    queryable.Where(a => a.ScheduledArrival == property);
                    break;
            }
        }

        return await queryable.Select(f => new FlightAllViewModel()
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
        }).ToListAsync(); ;
    }
}