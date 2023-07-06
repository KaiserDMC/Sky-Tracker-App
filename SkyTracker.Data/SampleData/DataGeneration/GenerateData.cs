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
#region Read CSV file and seed Flights, Aircraft and Airports
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
#endregion

#region Seed Airport and Aircraft data and pictures
            List<string> localPathsPictures = new List<string>();
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
            string[] files = Directory.GetFiles(folderPath, "*.jpg");

            for (int i = 0; i < files.Length; i++)
            {
                string currentPath = Path.Combine(folderPath, files[i]);

                localPathsPictures.Add(currentPath);
            }

            // This data seed replaces manual migration '20230705182832_Fix-AirportTable'
            airports[0].ICAO = "PANC";
            airports[0].CommonName = "Ted Stevens Anchorage International Airport";
            airports[0].Elevation = "151 ft";
            airports[0].LocationCity = "Anchorage";
            airports[0].LocationCountry = "United States";
            airports[0].ImagePathUrl = localPathsPictures[0];

            airports[1].ICAO = "KBID";
            airports[1].CommonName = "Block Island State Airport";
            airports[1].Elevation = "109 ft";
            airports[1].LocationCity = "Block Island";
            airports[1].LocationCountry = "United States";
            airports[1].ImagePathUrl = localPathsPictures[1];

            airports[2].ICAO = "KBUF";
            airports[2].CommonName = "Buffalo Niagara International Airport";
            airports[2].Elevation = "727 ft";
            airports[2].LocationCity = "Buffalo";
            airports[2].LocationCountry = "United States";
            airports[2].ImagePathUrl = localPathsPictures[2];

            airports[3].ICAO = "PAEN";
            airports[3].CommonName = "Kenai Municipal Airport";
            airports[3].Elevation = "99 ft";
            airports[3].LocationCity = "Kenai";
            airports[3].LocationCountry = "United States";
            airports[3].ImagePathUrl = localPathsPictures[3];

            airports[4].ICAO = "KGKT";
            airports[4].CommonName = "Gatlinburg-Pigeon Forge Airport";
            airports[4].Elevation = "1014 ft";
            airports[4].LocationCity = "Sevierville";
            airports[4].LocationCountry = "United States";
            airports[4].ImagePathUrl = localPathsPictures[4];

            airports[5].ICAO = "KIAG";
            airports[5].CommonName = "Niagara Falls International Airport";
            airports[5].Elevation = "592 ft";
            airports[5].LocationCity = "Niagara Falls";
            airports[5].LocationCountry = "United States";
            airports[5].ImagePathUrl = localPathsPictures[5];

            airports[6].ICAO = "TNCS";
            airports[6].CommonName = "Juancho E. Yrausquin Airport";
            airports[6].Elevation = "65 ft";
            airports[6].LocationCity = "Saba";
            airports[6].LocationCountry = "Netherlands";
            airports[6].ImagePathUrl = localPathsPictures[6];

            airports[7].ICAO = "TFFJ";
            airports[7].CommonName = "St. Gean Gustaf III Airport";
            airports[7].Elevation = "49 ft";
            airports[7].LocationCity = "Gustavia";
            airports[7].LocationCountry = "France";
            airports[7].ImagePathUrl = localPathsPictures[7];

            airports[8].ICAO = "TNCM";
            airports[8].CommonName = "Princess Juliana International Airport";
            airports[8].Elevation = "14 ft";
            airports[8].LocationCity = "Saint Martin";
            airports[8].LocationCountry = "Netherlands";
            airports[8].ImagePathUrl = localPathsPictures[8];

            airports[9].ICAO = "KWST";
            airports[9].CommonName = "Westerly State Airport";
            airports[9].Elevation = "81 ft";
            airports[9].LocationCity = "Westerly";
            airports[9].LocationCountry = "United States";
            airports[9].ImagePathUrl = localPathsPictures[9];

            airports[10].ICAO = "CYSN";
            airports[10].CommonName = "St. Catharines Niagara District Airport";
            airports[10].Elevation = "321 ft";
            airports[10].LocationCity = "Saint Catharines";
            airports[10].LocationCountry = "Canada";
            airports[10].ImagePathUrl = localPathsPictures[10];

            airports[11].ICAO = "CYHM";
            airports[11].CommonName = "John C. Munro Hamilton International Airport";
            airports[11].Elevation = "780 ft";
            airports[11].LocationCity = "Hamilton";
            airports[11].LocationCountry = "Canada";
            airports[11].ImagePathUrl = localPathsPictures[11];

            airports[12].ICAO = "CYKF";
            airports[12].CommonName = "Region of Waterloo International Airport";
            airports[12].Elevation = "1054 ft";
            airports[12].LocationCity = "Waterloo";
            airports[12].LocationCountry = "Canada";
            airports[12].ImagePathUrl = localPathsPictures[12];

            for (int i = 0; i < 5; i++)
            {
                aircraft[i].ImagePathUrl = localPathsPictures[i + 13];
            }
#endregion

            this.AircraftCollection = aircraft;
            this.AirportCollection = airports;
            this.FlightCollection = finalFlight;
        }
    }
}