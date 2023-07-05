namespace SkyTracker.Web.ViewModels.Airports;

public class AirportRunwayDetails
{
    public string RunwayDesignatorOne { get; set; } = null!;

    public string RunwayDesignatorTwo { get; set; } = null!;

    public int Length { get; set; }

    public int? Width { get; set; }

    public string? SurfaceType { get; set; }
}