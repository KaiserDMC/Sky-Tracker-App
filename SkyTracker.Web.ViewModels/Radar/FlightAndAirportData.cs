namespace SkyTracker.Web.ViewModels.Radar;

public class FlightAndAirportData
{
    public IEnumerable<FlightViewModel> Flights { get; set; } = new List<FlightViewModel>();
    public IEnumerable<AirportGeoDataViewModel> Airports { get; set; } = new List<AirportGeoDataViewModel>();
}