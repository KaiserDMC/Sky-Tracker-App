namespace SkyTracker.Web.ViewModels.Radar;

public class FlightViewModel
{
    public string FlightId { get; set; } = null!;

    public string? Equipment { get; set; }

    public string DepartureAirport { get; set; } = null!;
}