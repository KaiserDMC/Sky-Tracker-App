﻿namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class FlightAircraft
{
    [Required, ForeignKey(nameof(Aircraft))]
    public string AircraftId { get; set; } = null!;
    public Aircraft Aircraft { get; set; }

    [Required, ForeignKey(nameof(Flight))]
    public string FlightId { get; set; } = null!;
    public Flight Flight { get; set; }
}