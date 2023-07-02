﻿namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;
using static SkyTracker.Common.DataModelsValidationConstants.Aircraft;

public class Aircraft
{
    [Key]
    [Required]
    [MaxLength(AircraftIdLengthMax)]
    [RegularExpression(AircraftIdRegexPattern)]
    public string Id { get; set; } = null!;

    [MaxLength(RegistrationLengthMax)]
    [RegularExpression(RegistrationRegexPattern)]
    public string? Registration { get; set; }

    [MaxLength(EquipmentLengthMax)]
    [RegularExpression(EquipmentRegexPattern)]
    public string? Equipment { get; set; }

    public ICollection<FlightAircraft> FlightsAircraft { get; set; } = new HashSet<FlightAircraft>();
}