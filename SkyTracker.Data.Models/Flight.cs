namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static SkyTracker.Common.DataModelsValidationConstants.Flight;

public class Flight
{
    public Flight()
    {
        this.Id = Guid.NewGuid();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(FlightIdLengthMax)]
    [RegularExpression(FlightIdRegexPattern)]
    public int FlightId { get; set; }

    [Required]
    [MaxLength(AircraftIdLengthMax)]
    [RegularExpression(AircraftIdRegexPattern)]
    public string AircraftId { get; set; }
    public Aircraft Aircraft { get; set; } = null!;

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
    public string DepartureId { get; set; } = null!;
    public Airport ScheduledDeparture { get; set; } = null!;

    public string? ScheduledArrival { get; set; }

    public string? RealArrival { get; set; }

    public string? Reserved { get; set; }
}