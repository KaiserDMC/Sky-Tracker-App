namespace SkyTracker.Web.ViewModels.Airports;

using System.ComponentModel.DataAnnotations;

using static Common.DataModelsValidationConstants.Airport;
using static Common.ErrorMessageStrings.Airport;

public class AirportFormModel
{
    [Required]
    [StringLength(CodeIATALengthMax, MinimumLength = CodeIATALengthMin, ErrorMessage = IATALength)]
    [RegularExpression(CodeIATA, ErrorMessage = IATALength)]
    public string IATA { get; set; } = null!;

    [StringLength(CodeICAOLengthMax, MinimumLength = CodeICAOLengthMin, ErrorMessage = ICAOLength)]
    [RegularExpression(CodeICAO, ErrorMessage = ICAOLength)]
    public string? ICAO { get; set; }

    [StringLength(NameLengthMax, MinimumLength = NameLengthMin, ErrorMessage = CommonNameLength)]
    [RegularExpression(Name)]
    public string? CommonName { get; set; }

    [RegularExpression(Elev, ErrorMessage = ElevRegex)]
    public string? Elevation { get; set; }

    [StringLength(CityLengthMax,MinimumLength = CityLengthMin, ErrorMessage = CityLength)]
    public string? LocationCity { get; set; }

    [StringLength(CountryLengthMax,MinimumLength = CountryLengthMin, ErrorMessage = CountryLength)]
    public string? LocationCountry { get; set; }

    public string? ImagePathUrl { get; set; }

    [RegularExpression(LatLongRegexPattern, ErrorMessage = LatLongRegex)]
    public string? Lat { get; set; }

    [RegularExpression(LatLongRegexPattern, ErrorMessage = LatLongRegex)]
    public string? Long { get; set; }

    [Required]
    public string RunwayId { get; set; } = null!;

    public string? Error { get; set; }

    public IEnumerable<RunwayCollectionViewModel> Runways { get; set; } = new List<RunwayCollectionViewModel>();
}