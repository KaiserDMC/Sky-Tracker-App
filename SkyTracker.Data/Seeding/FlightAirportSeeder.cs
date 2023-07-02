namespace SkyTracker.Data.Seeding;

using Models;

using SampleData.DataGeneration;

public class FlightAirportSeeder
{
    public ICollection<Flight> Flights = new List<Flight>();

    public FlightAirportSeeder()
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