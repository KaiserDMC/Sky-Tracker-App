namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class RunwayAirport
{
    [Required,ForeignKey(nameof(Runway))]
    public string RunwayId { get; set; } = null!;
    public Runway Runway { get; set; } = null!;

    [Required,ForeignKey(nameof(Airport))]
    public string AirportId { get; set; } = null!;
    public Airport Airport { get; set; } = null!;
}