﻿namespace SkyTracker.Data.Seeding;

using Models;

using SampleData.DataGeneration;

public class FlightAirportSeeder
{
    public ICollection<Flight> flights = new List<Flight>();
    public ICollection<Airport> airport = new HashSet<Airport>();

    public FlightAirportSeeder()
    {
        var tempFlightCollection = new GenerateData().FlightCollection;

        foreach (var flightDTO in tempFlightCollection)
        {
            flights.Add(new Flight()
            {
                FlightId = flightDTO.FlightId,
                AircraftId = flightDTO.AircraftId,
                Registration = flightDTO.Registration,
                Equipment = flightDTO.Equipment,
                Callsign = flightDTO.Callsign,
                DepartureId = flightDTO.ScheduledDeparture,
                ArrivalId = flightDTO.ScheduledArrival,
                RealArrivalid = flightDTO.RealArrival,
                ReservedId = flightDTO.Reserved
            });
        }
    }
}