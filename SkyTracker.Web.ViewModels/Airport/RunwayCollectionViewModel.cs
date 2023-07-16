namespace SkyTracker.Web.ViewModels.Airports;

using System.ComponentModel.DataAnnotations;

using static Common.DataModelsValidationConstants.Runway;

public class RunwayCollectionViewModel
{
    [Key]
    public string Id { get; set; }

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
}