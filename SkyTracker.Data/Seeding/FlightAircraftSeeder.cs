namespace SkyTracker.Data.Seeding;

using SampleData.DataGeneration;
using Models;

public class FlightAircraftSeeder
{
    public ICollection<FlightAircraft> FlightAircraft = new List<FlightAircraft>();

    public FlightAircraftSeeder()
    {
        var tempFlightsCollection = new GenerateData().FlightCollection;
        var tempAircraftCollection = new GenerateData().AircraftCollection;

        var aircraftDictionary = tempAircraftCollection.ToDictionary(a => (a.Equipment, a.Registration), a => a.Id);

        foreach (var flight in tempFlightsCollection)
        {
            // Check if the aircraft exists in the dictionary
            if (aircraftDictionary.TryGetValue((flight.Equipment, flight.Registration), out var aircraftId))
            {
                FlightAircraft.Add(new FlightAircraft
                {
                    FlightId = flight.FlightId,
                    AircraftId = aircraftId
                });
            }
        }
    }
}