namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// This class represents the mapping between the Runway and Airport entities.
/// </summary>

public class RunwayAirport
{
    [Required,ForeignKey(nameof(Runway))]
    public Guid RunwayId { get; set; }
    public Runway Runway { get; set; } = null!;

    [Required,ForeignKey(nameof(Airport))]
    public string AirportId { get; set; } = null!;
    public Airport Airport { get; set; } = null!;
}