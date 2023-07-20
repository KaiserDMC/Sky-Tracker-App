namespace SkyTracker.Web.ViewModels.Flight;

public class FlightAircraftDetails
{
    public string Id { get; set; } = null!;
    public string? Registration { get; set; }
    public string? Equipment { get; set; }

    public string? ImagePathUrl { get; set; }
}