namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;

using static SkyTracker.Common.DataModelsValidationConstants.Runway;

/// <summary>
/// This class represents a runway in the database.
/// Regex pattern became slightly obsolete after the seed data was added through a JSON file.
/// However, it is kept here for future use.
/// </summary>

public class Runway
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [RegularExpression(DesignatorRegexPattern)]
    public string RunwayDesignatorOne { get; set; } = null!;

    [Required]
    [RegularExpression(DesignatorRegexPattern)]
    public string RunwayDesignatorTwo { get; set; } = null!;

    [Required]
    public int Length { get; set; }

    public int? Width { get; set; }

    public string? SurfaceType { get; set; }

    public bool IsDeleted { get; set; }

    public ICollection<RunwayAirport> RunwaysAirports { get; set; } = new List<RunwayAirport>();
}