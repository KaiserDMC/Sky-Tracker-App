namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static SkyTracker.Common.DataModelsValidationConstants.Runway;

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

    public ICollection<RunwayAirport> RunwaysAirports { get; set; } = new List<RunwayAirport>();
}