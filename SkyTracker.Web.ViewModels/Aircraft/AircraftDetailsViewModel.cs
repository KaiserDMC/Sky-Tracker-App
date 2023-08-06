namespace SkyTracker.Web.ViewModels.Aircraft;

public class AircraftDetailsViewModel
{
    public string Id { get; set; } = null!;

    public string Registration { get; set; } = null!;

    public string? Equipment { get; set; }

    public string ImageUrl { get; set; } = null!;

    public bool IsTotaled { get; set; }

    public string? Herald { get; set; }
}