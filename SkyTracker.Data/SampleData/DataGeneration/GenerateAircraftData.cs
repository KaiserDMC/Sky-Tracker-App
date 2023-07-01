namespace SkyTracker.Data.SampleData.DataGeneration;

using System.Globalization;

using CsvHelper;

using Seeding;
using SkyTracker.Data.Seeding.DTOs;

public class GenerateData
{
    public ICollection<AircraftSeedDTO> AircraftCollection = new HashSet<AircraftSeedDTO>();
    public ICollection<FlightSeedDTO> FlightCollection = new List<FlightSeedDTO>();

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
            var flights = csv.GetRecords<FlightSeedDTO>().ToList();
            int minimumFlightsPerDay = 3;

            // Filter flights that have the same aircraft_id and registration and flew at least twice
            var filteredFlights = flights
                .Where(f => !f.Equipment.Contains("C1") && (f.ScheduledDeparture != f.RealArrival) &&
                            (f.ScheduledArrival == f.RealArrival)
                            && !string.IsNullOrEmpty(f.Registration) && !string.IsNullOrEmpty(f.Equipment))
                .GroupBy(f => new { f.AircraftId, f.Registration })
                .Where(g => g.Count() >= minimumFlightsPerDay)
                .SelectMany(g => g)
                .ToList();

            // Save the filtered flights to the database
            var aircraft = filteredFlights
                .Select(f => new AircraftSeedDTO
                {
                    AircraftId = f.AircraftId,
                    Registration = f.Registration,
                    Equipment = f.Equipment
                })
                .Distinct()
                .ToHashSet();

            this.AircraftCollection = aircraft;
            this.FlightCollection = filteredFlights;
        }
    }

}