namespace SkyTracker.Web.ViewModels.Flight;

public class FlightAllViewModel
{
    public string FlightId { get; set; } = null!;

    public string? Registration { get; set; }

    public string? Equipment { get; set; }

    public string Callsign { get; set; } = null!;

    public string? FlightNumber { get; set; }

    public string DepartureId { get; set; } = null!;

    public string? ScheduledArrival { get; set; }

    public string? RealArrival { get; set; }

    public string? Reserved { get; set; }
}