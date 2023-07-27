namespace SkyTracker.Services.Data.Interfaces;

using Web.ViewModels.Aircraft;
using Web.ViewModels.Airports;
using Web.ViewModels.Flight;

public interface ISearchService
{
    Task<IEnumerable<AircraftAllViewModel>> SearchAircraftAsync(string query, string[] properties);

    Task<IEnumerable<AirportsAllViewModel>> SearchAirportsAsync(string query, string[] properties);

    Task<IEnumerable<FlightAllViewModel>> SearchFlightsAsync(string query, string[] properties);
}