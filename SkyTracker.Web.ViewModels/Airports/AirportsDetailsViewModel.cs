namespace SkyTracker.Web.ViewModels.Airports;

public class AirportsDetailsViewModel
{
    public string IATA { get; set; } = null!;

    public string? ICAO { get; set; }

    public string? CommonName { get; set; }

    public string? Elevation { get; set; }

    public string? LocationCity { get; set; }

    public string? LocationCountry { get; set; }

    public AirportRunwayDetails? Runway { get; set; }

    public string? ImageUrl { get; set; }
}