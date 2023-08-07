namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;

using static SkyTracker.Common.DataModelsValidationConstants.Airport;

/// <summary>
/// This class represents the Airport entity.
/// </summary>

public class Airport
{
    // IATA used as id instead of GUID to make the relationships easier. IATA codes are unique and governed by IATA.
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

    public string? ImagePathUrl { get; set; }

    [RegularExpression(LatLongRegexPattern)]
    public string? Lat { get; set; }

    [RegularExpression(LatLongRegexPattern)]
    public string? Long { get; set; }

    public bool IsDeleted { get; set; }

    public ICollection<RunwayAirport> RunwaysAirports { get; set; } = new List<RunwayAirport>();
}