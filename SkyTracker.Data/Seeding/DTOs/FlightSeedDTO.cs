namespace SkyTracker.Data.Seeding.DTOs;

using CsvHelper.Configuration.Attributes;

/// <summary>
/// DTO for the Flight entity.
/// CSV helper used to map the CSV file to the DTO.
/// </summary>

public class FlightSeedDto
{
    [Name("flight_id")]
    public string FlightId { get; set; } = null!;

    [Name("aircraft_id")]
    public string AircraftId { get; set; } = null!;

    [Name("reg")]
    public string? Registration { get; set; }

    [Name("equip")]
    public string? Equipment { get; set; }

    [Name("callsign")]
    public string Callsign { get; set; } = null!;

    [Name("flight")]
    public string? FlightNumber { get; set; }

    [Name("schd_from")]
    public string ScheduledDeparture { get; set; } = null!;

    [Name("schd_to")]
    public string? ScheduledArrival { get; set; }

    [Name("real_to")]
    public string? RealArrival { get; set; }

    [Name("reserved")]
    public string? Reserved { get; set; }
}