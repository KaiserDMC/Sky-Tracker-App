namespace SkyTracker.Data.Seeding.DTOs;

/// <summary>
/// DTO model for Aircraft entity.
/// </summary>

public class AircraftSeedDto
{
    public string AircraftId { get; set; } = null!;

    public string? Registration { get; set; }

    public string? Equipment { get; set; }
}