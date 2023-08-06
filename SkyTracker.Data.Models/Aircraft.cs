namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;

using static SkyTracker.Common.DataModelsValidationConstants.Aircraft;

public class Aircraft
{
    [Key]
    [Required]
    [MaxLength(AircraftIdLengthMax)]
    [RegularExpression(AircraftIdRegexPattern)]
    public string Id { get; set; } = null!;

    [Required]
    [MaxLength(RegistrationLengthMax)]
    [RegularExpression(RegistrationRegexPattern)]
    public string Registration { get; set; } = null!;

    [MaxLength(EquipmentLengthMax)]
    [RegularExpression(EquipmentRegexPattern)]
    public string? Equipment { get; set; }

    public string? ImagePathUrl { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsTotaled { get; set; }

    public ICollection<FlightAircraft> FlightsAircraft { get; set; } = new HashSet<FlightAircraft>();

    public ICollection<HeraldPost> AircraftRelatedHeralds { get; set; } = new HashSet<HeraldPost>();
}