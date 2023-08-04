namespace SkyTracker.Web.Areas.Admin.Services.Interfaces;

using ViewModels.Aircraft;
using ViewModels.Airports;
using ViewModels.Flight;
using ViewModels.Herald;

public interface IAdminService
{
    Task<IEnumerable<FlightAllViewModel>> GetFlightsAsync();

    Task<IEnumerable<AircraftAllViewModel>> GetAircraftAsync();

    Task<IEnumerable<AirportsAllViewModel>> GetAirportsAsync();

    Task<IEnumerable<HeraldAllViewModel>> GetHeraldsAsync();
}