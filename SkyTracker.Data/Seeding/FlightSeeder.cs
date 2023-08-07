namespace SkyTracker.Data.Seeding;

using DataGeneration;

using Models;

/// <summary>
/// This class is used to seed the database with flights, i.e. Flights table.
/// </summary>

public class FlightSeeder
{
    public ICollection<Flight> Flights = new List<Flight>();

    public FlightSeeder()
    {
        var tempFlightCollection = new GenerateData().FlightCollection;

        foreach (var flightDto in tempFlightCollection)
        {
            Flights.Add(new Flight
            {
                FlightId = flightDto.FlightId,
                Registration = flightDto.Registration,
                Equipment = flightDto.Equipment,
                Callsign = flightDto.Callsign,
                FlightNumber = flightDto.FlightNumber,
                DepartureId = flightDto.DepartureId,
                ScheduledArrival = flightDto.ScheduledArrival,
                RealArrival = flightDto.RealArrival,
                Reserved = flightDto.Reserved
            });
        }
    }
}