namespace SkyTracker.Data.Seeding;

using Newtonsoft.Json;

using Models;
using DTOs;

public class RunwaySeeder
{
    public ICollection<Runway> Runways = new List<Runway>();

    public RunwaySeeder()
    {
        Runways = GenerateRunways();
    }

    private ICollection<Runway> GenerateRunways()
    {
        ICollection<RunwaySeedDto>? runwaysDto = new List<RunwaySeedDto>();
        string[] surfaceTypes = new string[] { "Asphalt", "Concrete", "Grass", "Gravel", "Dirt", "Sand" };

        // Specify the folder name relative to the current directory
        string projectName = "_Sky-Tracker-info";
        string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string projectPath = currentDirectory;

        while (Path.GetFileName(projectPath) != projectName)
        {
            projectPath = Directory.GetParent(projectPath).FullName;
        }

        string relativePath = Path.Combine("SkyTracker.Data", "DataGeneration", "SampleData", "modified_runway.json");
        string fullPath = Path.Combine(projectPath, relativePath);

        string json = File.ReadAllText(fullPath);

        runwaysDto = JsonConvert.DeserializeObject<List<RunwaySeedDto>>(json);

        if (runwaysDto != null)
            foreach (var runwayDto in runwaysDto)
            {
                Runway runway = new()
                {
                    Id = Guid.ParseExact(runwayDto.Guid, "D"),
                    RunwayDesignatorOne = runwayDto.RunwayDesignatorOne,
                    RunwayDesignatorTwo = runwayDto.RunwayDesignatorTwo,
                    Length = new Random().Next(20, 100) * 50,
                    Width = new Random().Next(2, 20) * 30,
                    SurfaceType = surfaceTypes[new Random().Next(0, surfaceTypes.Length)]
                };

                Runways.Add(runway);
            }

        return Runways.ToArray();
    }
}