namespace SkyTracker.Services.Data;

using Microsoft.EntityFrameworkCore;

using SkyTracker.Data;
using Interfaces;
using Web.ViewModels.Airports;

public class AirportsService : IAirportsService
{
    private readonly SkyTrackerDbContext _dbContext;

    public AirportsService(SkyTrackerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<AirportsAllViewModel>> GetAllAirportsAsync()
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
                Lat = a.Lat,
                Long = a.Long,
                ImageUrl = a.ImagePathUrl
            })
            .ToListAsync();

        return airports;
    }

    public async Task<AirportsDetailsViewModel> GetAirportDetailsByIata(string iata)
    {
        var airport = await _dbContext.Airports
            .Where(a => a.IsDeleted == false)
            .Include(a => a.RunwaysAirports)
            .ThenInclude(ra => ra.Runway)
            .FirstOrDefaultAsync(a => a.IATA == iata);

        var airportDetails = new AirportsDetailsViewModel
        {
            IATA = airport.IATA,
            ICAO = airport.ICAO,
            CommonName = airport.CommonName,
            Elevation = airport.Elevation,
            LocationCity = airport.LocationCity,
            LocationCountry = airport.LocationCountry,
            Lat = airport.Lat,
            Long = airport.Long,
            Runway = airport.RunwaysAirports
                .Select(ra => ra.Runway)
                .Select(r => new AirportRunwayDetails()
                {
                    RunwayDesignatorOne = r.RunwayDesignatorOne,
                    RunwayDesignatorTwo = r.RunwayDesignatorTwo,
                    Length = r.Length,
                    Width = r.Width,
                    SurfaceType = r.SurfaceType
                })
            .FirstOrDefault()
        };

        return airportDetails;
    }
}