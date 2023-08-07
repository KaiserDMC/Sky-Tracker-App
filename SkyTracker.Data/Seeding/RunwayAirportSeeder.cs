namespace SkyTracker.Data.Seeding;

using DataGeneration;

using Models;

/// <summary>
/// This class is used to seed the RunwayAirport mapping table in the database.
/// </summary>

public class RunwayAirportSeeder
{
    public ICollection<RunwayAirport> RunwayAirports = new List<RunwayAirport>();
    private ICollection<string> _runwayIds;
    private readonly RunwaySeeder _runwaySeeder = new();

    public RunwayAirportSeeder()
    {
        var tempAirportCollection = new GenerateData().AirportCollection;
        _runwayIds = _runwaySeeder.Runways.Select(r => r.Id.ToString()).ToList();

        foreach (var airport in tempAirportCollection)
        {
            var randomRunwayId = _runwayIds.ElementAt(new Random().Next(0, _runwayIds.Count));

            RunwayAirports.Add(new RunwayAirport
            {
                AirportId = airport.IATA,
                RunwayId = Guid.ParseExact(randomRunwayId, "D")
            });
        }
    }
}