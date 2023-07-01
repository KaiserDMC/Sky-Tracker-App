namespace SkyTracker.Data.Seeding.DTOs;

using CsvHelper.Configuration.Attributes;

public class FlightSeedDTO
{
    [Name("flight_id")]
    public int FlightId { get; set; }

    [Name("aircraft_id")]
    public int AircraftId { get; set; }

    [Name("reg")]
    public string? Registration { get; set; }

    [Name("equip")]
    public string? Equipment { get; set; }

    [Name("callsign")]
    public string Callsign { get; set; } = null!;

    [Name("flight")]
    public string? FlightNumber { get; set; }

    [Name("schd_from")]
    public string ScheduledDeparture { get; set; }  = null!;

    [Name("schd_to")]
    public string? ScheduledArrival { get; set; }

    [Name("real_to")]
    public string? RealArrival { get; set; }

    [Name("reserved")]
    public string? Reserved { get; set; }
}