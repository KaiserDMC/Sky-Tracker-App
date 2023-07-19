using SkyTracker.Web.ViewModels.Flight;

namespace SkyTracker.Services.Data;

using Microsoft.EntityFrameworkCore;

using SkyTracker.Data;
using Interfaces;
using Web.ViewModels.Radar;

public class RadarService : IRadarService
{
    private readonly SkyTrackerDbContext _dbContext;

    public RadarService(SkyTrackerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<AirportGeoDataViewModel>> GetAirportsGeoDataAsync()
    {
        var airportsToPlot = await _dbContext.Airports
            .Where(a => a.IsDeleted == false)
            .OrderBy(a => a.IATA)
            .Select(a => new AirportGeoDataViewModel()
            {
                Iata = a.IATA,
                Icao = a.ICAO,
                Name = a.CommonName,
                Latitude = a.Lat,
                Longitude = a.Long
            })
            .ToListAsync();

        return airportsToPlot;
    }

    public async Task<IEnumerable<FlightViewModel>> GetFlightsForMapAsync()
    {
        string[] flightIds = new string[]
        {
            "679614404",
            "679635572",
            "679709505",
            "679719352",
            "679750895",
            "679803953"
        };

        var flights = await _dbContext.Flights
            .Where(f => f.IsDeleted == false)
            .Where(f => flightIds.Contains(f.FlightId))
            .ToListAsync();

        // Map the flight data to the view model
        var flightViewModels = flights.Select(f => new FlightViewModel
        {
            FlightId = f.FlightId,
            Equipment = f.Equipment,
            DepartureAirport = f.DepartureId
        });

        return flightViewModels;
    }

    public async Task<FlightAndAirportData> GetFlightAndAirportDataAsync()
    {
        var flights = await GetFlightsForMapAsync();
        var airports = await GetAirportsGeoDataAsync();

        var data = new FlightAndAirportData
        {
            Flights = flights,
            Airports = airports
        };

        return data;
    }
}