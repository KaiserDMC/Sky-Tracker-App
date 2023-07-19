namespace SkyTracker.Web.ViewModels.Radar;

public class FlightAndAirportData
{
    public IEnumerable<FlightViewModel> Flights { get; set; }
    public IEnumerable<AirportGeoDataViewModel> Airports { get; set; }
}