namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;

using static SkyTracker.Common.DataModelsValidationConstants.Airport;

public class Airport
{
    [Key]
    [Required]
    [RegularExpression(CodeIATA)]
    public string IATA { get; set; } = null!;

    [RegularExpression(CodeICAO)]
    public string? ICAO { get; set; }

    public ICollection<RunwayAirport> RunwaysAirports { get; set; } = new List<RunwayAirport>();
}