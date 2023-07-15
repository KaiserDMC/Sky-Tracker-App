namespace SkyTracker.Web.ViewModels.Airports;

public class AirportsAllViewModel
{
    public string IATA { get; set; } = null!;

    public string? ICAO { get; set; }

    public string? CommonName { get; set; }

    public string? Elevation { get; set; }

    public string? LocationCity { get; set; }

    public string? LocationCountry { get; set; }

    public string? Lat { get; set; }

    public string? Long { get; set; }

    public string? ImageUrl { get; set; }
}