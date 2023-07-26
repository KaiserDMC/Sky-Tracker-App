namespace SkyTracker.Web.ViewModels.Flight;

using System.ComponentModel.DataAnnotations;

using static SkyTracker.Common.DataModelsValidationConstants.Flight;
using static SkyTracker.Common.ErrorMessageStrings.Flight;

public class AirportCollectionViewModel
{
    public string Id { get; set; } = null!;

    [Required]
    [RegularExpression(CodeIATA, ErrorMessage = CodeIATARegex)]
    public string NameIATA { get; set; } = null!;
}