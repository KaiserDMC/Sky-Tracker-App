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

    [RegularExpression(Name)]
    public string? CommonName { get; set; }

    [RegularExpression(Elev)]
    public string? Elevation { get; set; }

    public string? LocationCity { get; set; }

    public string? LocationCountry { get; set; }

    [Required]
    public string ImagePathUrl { get; set; } = null!;

    [RegularExpression(LatLongRegexPattern)]
    public string? Lat { get; set; }

    [RegularExpression(LatLongRegexPattern)]
    public string? Long { get; set; }

    public bool IsDeleted { get; set; }

    public ICollection<RunwayAirport> RunwaysAirports { get; set; } = new List<RunwayAirport>();
}