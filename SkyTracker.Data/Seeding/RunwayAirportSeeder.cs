namespace SkyTracker.Data.Seeding;

using Models;

using SampleData.DataGeneration;

public class RunwayAirportSeeder
{
    public ICollection<RunwayAirport> RunwayAirports = new List<RunwayAirport>();
    private ICollection<string> RunwayIds = new HashSet<string>();
    private readonly RunwaySeeder _runwaySeeder = new RunwaySeeder();

    public RunwayAirportSeeder()
    {
        var tempAirportCollection = new GenerateData().AirportCollection;
        RunwayIds = _runwaySeeder.Runways.Select(r => r.Id).ToList();

        foreach (var airport in tempAirportCollection)
        {
            var randomRunwayId = RunwayIds.ElementAt(new Random().Next(0, RunwayIds.Count));

            RunwayAirports.Add(new RunwayAirport
            {
                AirportId = airport.IATA,
                RunwayId = randomRunwayId
            });
        }
    }
}