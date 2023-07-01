namespace SkyTracker.Data.Seeding;


using System.Collections;
using SkyTracker.Data.Models;
using SkyTracker.Data.Seeding.DTOs;


using Newtonsoft.Json;

using SkyTracker.Data.SampleData.DataGeneration;

public class RunwaySeeder
{
    internal object[] GenerateRunways()
    {
        ICollection<RunwaySeedDTO>? runwaysDTO = new List<RunwaySeedDTO>();
        string[] surfaceTypes = new string[] { "Asphalt", "Concrete", "Grass", "Gravel", "Dirt", "Sand" };
        ICollection<Runway> runways = new List<Runway>();

        // Specify the folder name relative to the current directory
        string relativePath = @"..\SkyTracker.Data\SampleData\ruwnway_designators.json";
        string fullPath = Path.GetFullPath(relativePath);
        
        string json = File.ReadAllText(fullPath);

        runwaysDTO = JsonConvert.DeserializeObject<List<RunwaySeedDTO>>(json);

        foreach (var runwayDTO in runwaysDTO)
        {
            Runway runway = new()
            {
                RunwayDesignatorOne = runwayDTO.RunwayDesignatorOne,
                RunwayDesignatorTwo = runwayDTO.RunwayDesignatorTwo,
                Length = new Random().Next(1000, 5000),
                Width = new Random().Next(60, 600),
                SurfaceType = surfaceTypes[new Random().Next(0, surfaceTypes.Length)]
            };

            runways.Add(runway);
        }

        return runways.ToArray();
    }
}