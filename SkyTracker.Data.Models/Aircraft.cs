namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;

using static SkyTracker.Common.DataModelsValidationConstants.Aircraft;

/// <summary>
/// Model representing an aircraft entity used in the database.
/// </summary>

public class Aircraft
{
    // Aircraft id used from the provided csv file. As EF Core was not happy with PrincipleKey and ForeignKey attributes between Aircraft and Flight entities.
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