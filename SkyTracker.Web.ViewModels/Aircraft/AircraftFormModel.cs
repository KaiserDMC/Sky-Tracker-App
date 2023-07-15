namespace SkyTracker.Web.ViewModels.Aircraft;

using System.ComponentModel.DataAnnotations;

public class AircraftFormModel
{
    [Required]
    public string Id { get; set; } = null!;

    [Required]
    public string Registration { get; set; } = null!;

    public string? Equipment { get; set; }

    public string? ImagePathUrl { get; set; }

    public string? Error { get; set; }
}