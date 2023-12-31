﻿namespace SkyTracker.Services.Data;

using Interfaces;

using Microsoft.EntityFrameworkCore;

using SkyTracker.Data;
using SkyTracker.Data.Models;

using Web.ViewModels.Aircraft;
using Web.ViewModels.Airport;
using Web.ViewModels.Flight;

/// <summary>
/// Search Service is used to query the database and provide search results for: Aircraft, Airports and Flights.
/// The query includes a "search parameter" and certain properties chosen from a radio or checkbox button.
/// </summary>

public class SearchService : ISearchService
{
    private readonly SkyTrackerDbContext _dbContext;

    public SearchService(SkyTrackerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<AircraftAllViewModel>> SearchAircraftAsync(string query, string[] properties)
    {
        if (string.IsNullOrEmpty(query) || properties == null || properties.Length == 0)
        {
            return null;
        }

        IQueryable<Aircraft> queryable = _dbContext.Aircraft.AsQueryable();

        string property = properties.First();

        switch (property)
        {
            case "aircraftId":
                queryable = queryable.Where(a => a.Id == query || a.Id.Contains(query));
                break;
            case "aircraftRegistration":
                queryable = queryable.Where(a => a.Registration == query || a.Registration.Contains(query));
                break;
            case "aircraftEquipment":
                queryable = queryable.Where(a => a.Equipment == query || a.Equipment.Contains(query));
                break;
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
        if (string.IsNullOrEmpty(query) || properties == null || properties.Length == 0)
        {
            return null;
        }

        IQueryable<Airport> queryable = _dbContext.Airports.AsQueryable();

        string property = properties.First();

        switch (property)
        {
            case "airportIata":
                queryable = queryable.Where(a => a.IATA == query || a.IATA.Contains(query));
                break;
            case "airportIcao":
                queryable = queryable.Where(a => a.ICAO == query || a.ICAO.Contains(query));
                break;
            case "airportName":
                queryable = queryable.Where(a => a.CommonName == query || a.CommonName.Contains(query));
                break;
            case "airportCity":
                queryable = queryable.Where(a => a.LocationCity == query || a.LocationCity.Contains(query));
                break;
            case "airportCountry":
                queryable = queryable.Where(a => a.LocationCountry == query || a.LocationCountry.Contains(query));
                break;
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
        if (string.IsNullOrEmpty(query)|| properties == null || properties.Length == 0)
        {
            return null;
        }

        IQueryable<Flight> queryable = _dbContext.Flights.AsQueryable();

        var separatedQuery = query.Split(' ');

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