namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static SkyTracker.Common.DataModelsValidationConstants.Flight;

public class Flight
{
    [Key]
    [Required]
    [MaxLength(FlightIdLengthMax)]
    [RegularExpression(FlightIdRegexPattern)]
    public string FlightId { get; set; } = null!;

    //[Required]
    //[MaxLength(AircraftIdLengthMax)]
    //[RegularExpression(AircraftIdRegexPattern)]
    //public string AircraftId { get; set; } = null!;
    //[ForeignKey("AircraftId")]
    //public Aircraft Aircraft { get; set; } = null!;

    [MaxLength(RegistrationLengthMax)]
    [RegularExpression(RegistrationRegexPattern)]
    public string? Registration { get; set; }

    [MaxLength(EquipmentLengthMax)]
    [RegularExpression(EquipmentRegexPattern)]
    public string? Equipment { get; set; }

    [Required]
    [MaxLength(CallsignLengthMax)]
    [RegularExpression(CallsignRegexPattern)]
    public string Callsign { get; set; } = null!;

    [MaxLength(FlightNumberLengthMax)]
    [RegularExpression(FlightNumberRegexPattern)]
    public string? FlightNumber { get; set; }

    [Required, ForeignKey(nameof(ScheduledDeparture))]
    [RegularExpression(CodeIATA)]
    public string DepartureId { get; set; } = null!;
    public Airport ScheduledDeparture { get; set; } = null!;

    [RegularExpression(CodeIATA)]
    public string? ScheduledArrival { get; set; }

    [RegularExpression(CodeIATA)]
    public string? RealArrival { get; set; }

    [RegularExpression(CodeIATA)]
    public string? Reserved { get; set; }

    public ICollection<FlightAircraft> FlightsAircraft { get; set; } = new HashSet<FlightAircraft>();
}