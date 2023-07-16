namespace SkyTracker.Web.ViewModels.Airports;

using System.ComponentModel.DataAnnotations;
using static Common.DataModelsValidationConstants.Airport;
using static Common.ErrorMessageStrings.Airport;

public class AirportFormModel
{
    [Required]
    [RegularExpression(CodeIATA)]
    [StringLength(3, ErrorMessage = IATALength)]
    public string IATA { get; set; } = null!;

    [RegularExpression(CodeICAO)]
    [StringLength(4, ErrorMessage = ICAOLength)]
    public string? ICAO { get; set; }

    [RegularExpression(Name)]
    [StringLength(NameLengthMax, ErrorMessage = CommonNameLength)]
    public string? CommonName { get; set; }

    [RegularExpression(Elev)]
    [MinLength(0, ErrorMessage = ElevRegex)]
    public string? Elevation { get; set; }

    [StringLength(CityLengthMax, ErrorMessage = CityLength)]
    public string? LocationCity { get; set; }

    [StringLength(CountryLengthMax, ErrorMessage = CountryLength)]
    public string? LocationCountry { get; set; }

    public string? ImagePathUrl { get; set; }

    [RegularExpression(LatLongRegexPattern)]
    public string? Lat { get; set; }

    [RegularExpression(LatLongRegexPattern)]
    public string? Long { get; set; }
    
    public string RunwayId { get; set; } = null!;

    public string? Error { get; set; }

    public IEnumerable<RunwayCollectionViewModel> Runways { get; set; } = new List<RunwayCollectionViewModel>();
}