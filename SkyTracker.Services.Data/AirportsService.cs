using SkyTracker.Common;
using SkyTracker.Data.Models;

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

    public async Task<IEnumerable<RunwayCollectionViewModel>> GetRunwaysCollectionAsync()
    {
        var runways = await _dbContext.Runways
            .Where(r => r.IsDeleted == false)
            .OrderBy(r => r.RunwayDesignatorOne)
            .Select(r => new RunwayCollectionViewModel
            {
                RunwayDesignatorOne = r.RunwayDesignatorOne,
                RunwayDesignatorTwo = r.RunwayDesignatorTwo,
                Length = r.Length,
                Width = r.Width,
                SurfaceType = r.SurfaceType
            })
            .ToListAsync();

        return runways;
    }

    public async Task AddAirportAsync(AirportFormModel model)
    {
        if (_dbContext.Airports.Any(a => a.IATA == model.IATA))
        {
            model.Error = "Airport with this IATA code already exists.";
        }

        Airport airport = new Airport
        {
            IATA = model.IATA,
            ICAO = model.ICAO,
            CommonName = model.CommonName,
            Elevation = model.Elevation,
            LocationCity = model.LocationCity,
            LocationCountry = model.LocationCountry,
            Lat = model.Lat,
            Long = model.Long,
            ImagePathUrl = model.ImagePathUrl,
        };

        await _dbContext.Airports.AddAsync(airport);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<AirportFormModel> GetAirportbyIataAsync(string iata)
    {
        var airportById = await _dbContext.Airports
            .Where(a => a.IsDeleted == false)
            .Include(r => r.RunwaysAirports)
            .FirstOrDefaultAsync(a => a.IATA == iata);

        if (airportById != null)
        {
            var airport = new AirportFormModel
            {
                IATA = airportById.IATA,
                ICAO = airportById.ICAO,
                CommonName = airportById.CommonName,
                Elevation = airportById.Elevation,
                LocationCity = airportById.LocationCity,
                LocationCountry = airportById.LocationCountry,
                Lat = airportById.Lat,
                Long = airportById.Long,
                ImagePathUrl = airportById.ImagePathUrl,
                RunwayId = airportById.RunwaysAirports.Select(ra => ra.RunwayId.ToString())
                    .FirstOrDefault()
            };

            return airport;
        }

        return null;
    }

    public async Task EditAirportAsync(string iata, AirportFormModel model)
    {
        var airportToUpdate = await _dbContext.Airports
            .Where(a => a.IsDeleted == false)
            .FirstOrDefaultAsync(a => a.IATA == iata);

        var runway = await _dbContext.Runways
            .Where(r => r.IsDeleted == false)
            .FirstOrDefaultAsync(r => r.RunwayDesignatorOne == model.RunwayId);

        var currentRunway = await _dbContext.RunwaysAirports
            .FirstOrDefaultAsync(ra => ra.AirportId == airportToUpdate.IATA);

        airportToUpdate.RunwaysAirports.Remove(currentRunway);

        var airportRunway = new RunwayAirport()
        {
            AirportId = airportToUpdate.IATA,
            Airport = airportToUpdate,
            RunwayId = runway.Id,
            Runway = runway
        };

        if (airportToUpdate != null)
        {
            airportToUpdate.IATA = model.IATA;
            airportToUpdate.ICAO = model.ICAO;
            airportToUpdate.CommonName = model.CommonName;
            airportToUpdate.Elevation = model.Elevation;
            airportToUpdate.LocationCity = model.LocationCity;
            airportToUpdate.LocationCountry = model.LocationCountry;
            airportToUpdate.Lat = model.Lat;
            airportToUpdate.Long = model.Long;
            airportToUpdate.ImagePathUrl = model.ImagePathUrl;
            airportToUpdate.RunwaysAirports.Add(airportRunway);
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAirportAsync(string[] iataCodes)
    {
        var airportsToDelete = await _dbContext.Airports
            .Where(a => a.IsDeleted == false)
            .Where(a => iataCodes.Contains(a.IATA))
            .Include(ra => ra.RunwaysAirports)
            .ToListAsync();

        
        foreach (var airport in airportsToDelete)
        {
            airport.IsDeleted = true;

            var currentRunway = await _dbContext.RunwaysAirports
                .FirstOrDefaultAsync(ra => ra.AirportId == airport.IATA);

            airport.RunwaysAirports.Remove(currentRunway);
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<AirportsAllViewModel>> GetDeletedAirportsAsync()
    {
        var airports = await _dbContext.Airports
            .Where(a => a.IsDeleted == true)
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

    public async Task AddRunwayToAirportAsync(string iata, string runwayDesignatorOne)
    {
        var airport = await _dbContext.Airports
            .Where(a => a.IsDeleted == false)
            .FirstOrDefaultAsync(a => a.IATA == iata);

        var runway = await _dbContext.Runways
            .Where(r => r.IsDeleted == false)
            .FirstOrDefaultAsync(r => r.RunwayDesignatorOne == runwayDesignatorOne);

        var airportRunway = new RunwayAirport()
        {
            AirportId = airport.IATA,
            Airport = airport,
            RunwayId = runway.Id,
            Runway = runway
        };

        await _dbContext.RunwaysAirports.AddAsync(airportRunway);
        await _dbContext.SaveChangesAsync();
    }
}