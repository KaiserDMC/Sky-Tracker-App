namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Represents the mapping between a flight and an aircraft.
/// </summary>

public class FlightAircraft
{
    [Required, ForeignKey(nameof(Aircraft))]
    public string AircraftId { get; set; } = null!;
    public Aircraft Aircraft { get; set; } = null!;

    [Required, ForeignKey(nameof(Flight))]
    public string FlightId { get; set; } = null!;
    public Flight Flight { get; set; } = null!;
}