namespace SkyTracker.Web.ViewModels.Aircraft;

using System.ComponentModel.DataAnnotations;
using static SkyTracker.Common.DataModelsValidationConstants.Aircraft;
using static SkyTracker.Common.ErrorMessageStrings.Aircraft;

public class AircraftFormModel
{
    [Required]
    [StringLength(AircraftIdLengthMax, MinimumLength = AircraftIdLengthMin, ErrorMessage = AircraftIdLengthError)]
    [RegularExpression(AircraftIdRegexPattern, ErrorMessage = AircraftIdRegexError)]
    public string Id { get; set; } = null!;

    [Required]
    [StringLength(RegistrationLengthMax, MinimumLength = RegistrationLengthMin, ErrorMessage = RegistrationLengthError)]
    [RegularExpression(RegistrationRegexPattern, ErrorMessage = RegistrationRegexError)]
    public string Registration { get; set; } = null!;

    [StringLength(EquipmentLengthMax, MinimumLength = EquipmentLengthMin, ErrorMessage = EquipmentLengthError)]
    [RegularExpression(EquipmentRegexPattern, ErrorMessage = EquipmentRegexError)]
    public string? Equipment { get; set; }

    public string? ImagePathUrl { get; set; }

    public string? Error { get; set; }

    public bool IsTotaled { get; set; }
}