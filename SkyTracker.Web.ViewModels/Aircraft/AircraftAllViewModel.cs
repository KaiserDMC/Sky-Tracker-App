namespace SkyTracker.Web.ViewModels.Aircraft;

public class AircraftAllViewModel
{
    public string Id { get; set; } = null!;

    public string Registration { get; set; } = null!;

    public string? Equipment { get; set; }

    public string? ImageUrl { get; set; }
}