namespace SkyTracker.Services.Data.Interfaces;

using Web.ViewModels.Herald;
using Web.ViewModels.Aircraft;
using Web.ViewModels.Airports;
using Web.ViewModels.Flight;
using Web.ViewModels.User;

public interface IAdminService
{
    Task<IEnumerable<FlightAllViewModel>> GetFlightsAsync();

    Task<IEnumerable<AircraftAllViewModel>> GetAircraftAsync();

    Task<IEnumerable<AirportsAllViewModel>> GetAirportsAsync();

    Task<IEnumerable<HeraldAllViewModel>> GetHeraldsAsync();
}