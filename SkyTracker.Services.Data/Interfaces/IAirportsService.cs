using SkyTracker.Web.ViewModels.Airports;

namespace SkyTracker.Services.Data.Interfaces;

public interface IAirportsService
{
    Task<IEnumerable<AirportsAllViewModel>> GetAllAirportsAsync();

    Task<AirportsDetailsViewModel> GetAirportDetailsByIata(string iata);
}