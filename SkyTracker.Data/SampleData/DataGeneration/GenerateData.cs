namespace SkyTracker.Data.SampleData.DataGeneration;

using System.Globalization;

using CsvHelper;

using Seeding;
using Models;
using Seeding.DTOs;

public class GenerateData
{
    public ICollection<Aircraft> AircraftCollection = new HashSet<Aircraft>();
    public ICollection<Flight> FlightCollection = new List<Flight>();
    public ICollection<Airport> AirportCollection = new List<Airport>();



    public GenerateData()
    {
        GenerateFlightAndAircraftData();
    }

    private void GenerateFlightAndAircraftData()
    {
        string relativePath = @"..\SkyTracker.Data\SampleData\DataGeneration\20210723_flights.csv";
        string fullPath = Path.GetFullPath(relativePath);

        using (var reader = new StreamReader(fullPath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var flights = csv.GetRecords<FlightSeedDto>().ToList();
            int minimumFlightsPerDay = 3;

            // Filter flights that have the same aircraft_id and registration and flew at least twice
            var filteredFlights = flights
                .Where(f =>
                            f.Equipment != null
                            && !f.Equipment.Contains("C1")
                            && (f.ScheduledDeparture != f.RealArrival)
                            && (f.ScheduledArrival == f.RealArrival)
                            && !string.IsNullOrEmpty(f.Registration)
                            && !string.IsNullOrEmpty(f.Equipment)
                            && !string.IsNullOrEmpty(f.ScheduledDeparture)
                            && !string.IsNullOrEmpty(f.ScheduledArrival))
                .GroupBy(f => new { f.AircraftId, f.Registration })
                .Where(g => g.Count() >= minimumFlightsPerDay)
                .OrderByDescending(g => g.Count())
                .SelectMany(g => g)
                .Take(100)
                .ToList();

            // Save the filtered flights to the database
            var aircraftDto = filteredFlights
                .Select(f => new AircraftSeedDto
                {
                    AircraftId = f.AircraftId,
                    Registration = f.Registration,
                    Equipment = f.Equipment
                })
                .ToHashSet();

            var aircraft = aircraftDto
                .GroupBy(a => a.AircraftId)
                .Select(g => g.First())
                .Select(a => new Aircraft
                {
                    Id = a.AircraftId,
                    Registration = a.Registration,
                    Equipment = a.Equipment
                })
                .ToList();

            var finalFlight = new List<Flight>();
            foreach (var ff in filteredFlights)
            {
                var currentFlight = new Flight
                {
                    FlightId = ff.FlightId,
                    Registration = ff.Registration,
                    Equipment = ff.Equipment,
                    Callsign = ff.Callsign,
                    DepartureId = ff.ScheduledDeparture,
                    ScheduledArrival = ff.ScheduledArrival,
                    RealArrival = ff.RealArrival,
                    Reserved = ff.Reserved
                };

                finalFlight.Add(currentFlight);
            }

            var airports = filteredFlights.Select(a => a.ScheduledDeparture).Distinct()
                .Select(f => new Airport
                {
                    IATA = f
                })
                .ToList();

            this.AircraftCollection = aircraft;
            this.AirportCollection = airports;
            this.FlightCollection = finalFlight;
        }
    }
}