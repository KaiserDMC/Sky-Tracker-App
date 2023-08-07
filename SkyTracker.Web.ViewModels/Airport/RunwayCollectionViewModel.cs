namespace SkyTracker.Web.ViewModels.Airport;

using System.ComponentModel.DataAnnotations;

using static Common.DataModelsValidationConstants.Runway;
using static Common.ErrorMessageStrings.Runway;

public class RunwayCollectionViewModel
{
    [Key]
    public string Id { get; set; } = null!;

    [Required]
    [RegularExpression(DesignatorRegexPattern, ErrorMessage = RunwayDesignatorError)]
    public string RunwayDesignatorOne { get; set; } = null!;

    [Required]
    [RegularExpression(DesignatorRegexPattern, ErrorMessage = RunwayDesignatorError)]
    public string RunwayDesignatorTwo { get; set; } = null!;

    [Required]
    [StringLength(LengthLengthMax, MinimumLength = LengthLengthMin, ErrorMessage = RunwayLengthError)]
    [RegularExpression(LengthRegexPattern, ErrorMessage = RunwayLengthError)]
    public int Length { get; set; }

    [StringLength(WidthLengthMax, MinimumLength = WidthLengthMin, ErrorMessage = WidthLenghError)]
    [RegularExpression(WidthRegexPattern, ErrorMessage = WidthLenghError)]
    public int? Width { get; set; }

    public string? SurfaceType { get; set; }
}