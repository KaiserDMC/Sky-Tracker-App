namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;
using static SkyTracker.Common.DataModelsValidationConstants.Aircraft;

public class Aircraft
{
    public Aircraft()
    {
        this.Id = Guid.NewGuid();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(AircraftIdLengthMax)]
    [RegularExpression(AircraftIdRegexPattern)]
    public string AircraftId { get; set; }

    [MaxLength(RegistrationLengthMax)]
    [RegularExpression(RegistrationRegexPattern)]
    public string? Registration { get; set; }

    [MaxLength(EquipmentLengthMax)]
    [RegularExpression(EquipmentRegexPattern)]
    public string? Equipment { get; set; }

    public ICollection<Flight> Flights { get; set; } = new HashSet<Flight>();
}