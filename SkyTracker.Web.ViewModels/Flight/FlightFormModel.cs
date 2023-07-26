namespace SkyTracker.Web.ViewModels.Flight;

using System.ComponentModel.DataAnnotations;

using static SkyTracker.Common.DataModelsValidationConstants.Flight;
using static SkyTracker.Common.ErrorMessageStrings.Flight;

public class FlightFormModel
{
    [Required]
    [StringLength(FlightIdLengthMax, MinimumLength = FlightIdLengthMin, ErrorMessage = FlightIdLength)]
    [RegularExpression(FlightIdRegexPattern, ErrorMessage = FlightIdRegex)]
    public string FlightId { get; set; } = null!;

    public string? Registration { get; set; }

    [Display(Name = "A/C Type")]
    public string? Equipment { get; set; }

    [Required]
    [StringLength(CallsignLengthMax, MinimumLength = CallsignLengthMin, ErrorMessage = CallsignLength)]
    [RegularExpression(CallsignRegexPattern, ErrorMessage = CallsignRegex)]
    [Display(Name = "CallSign")]
    public string Callsign { get; set; } = null!;

    [StringLength(FlightNumberLengthMax, MinimumLength = FlightNumberLengthMin, ErrorMessage = FlightNumberLength)]
    [RegularExpression(FlightNumberRegexPattern, ErrorMessage = FlightNumberRegex)]
    public string? FlightNumber { get; set; }

    [Required]
    [Display(Name = "Departure airport IATA")]
    public string DepartureId { get; set; } = null!;

    [Display(Name = "Scheduled arrival airport IATA")]
    public string? ScheduledArrival { get; set; } = null!;

    [Display(Name = "Actual arrival airport IATA")]
    public string? RealArrival { get; set; }

    [Display(Name = "Reserve airport IATA")]
    public string? Reserved { get; set; }

    public string? Error { get; set; }

    public IEnumerable<AircraftCollectionViewModel> AircraftList { get; set; } = new List<AircraftCollectionViewModel>();

    public IEnumerable<AirportCollectionViewModel> AirportListDeparture { get; set; } = new List<AirportCollectionViewModel>();
    public IEnumerable<AirportCollectionViewModel>? AirportListArrival { get; set; } = new List<AirportCollectionViewModel>();
    public IEnumerable<AirportCollectionViewModel>? AirportListActual { get; set; } = new List<AirportCollectionViewModel>();
    public IEnumerable<AirportCollectionViewModel>? AirporListReserved { get; set; } = new List<AirportCollectionViewModel>();
}