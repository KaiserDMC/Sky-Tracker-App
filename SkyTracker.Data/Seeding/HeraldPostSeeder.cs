namespace SkyTracker.Data.Seeding;

using System.Globalization;

using Models;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using SampleData;

public class HeraldPostSeeder
{
    internal HeraldPost[] GenerateHeraldPosts()
    {
        ICollection<HeraldPost>? heraldPosts;

        // Specify the folder name relative to the current directory
        string projectName = "_Sky-Tracker-info";
        string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string projectPath = currentDirectory;

        while (Path.GetFileName(projectPath) != projectName)
        {
            projectPath = Directory.GetParent(projectPath).FullName;
        }

        string relativePath = Path.Combine("SkyTracker.Data", "DataGeneration", "SampleData", "modified_avherald.json");
        string fullPath = Path.Combine(projectPath, relativePath);

        string json = File.ReadAllText(fullPath);

        JArray jsonArray = JArray.Parse(json);

        foreach (JObject obj in jsonArray)
        {
            string occurrence = (string)obj["Occurrence"];
            DateTime date = DateTime.ParseExact(occurrence, "dddd MMM d yyyy", CultureInfo.InvariantCulture);

            string formattedDate = date.ToString("dddd MMM d yyyy");

            // Update the JSON with the modified date
            obj["Occurrence"] = formattedDate;
        }

        // Convert the modified JSON back to a string
        string modifiedJson = jsonArray.ToString();

        heraldPosts = JsonConvert.DeserializeObject<HashSet<HeraldPost>>(json);

        // Add AircraftId to some Heralds on random principle

        var tempAircraftCollection = new GenerateData().AircraftCollection;

        foreach (var aircraft in tempAircraftCollection)
        {
            var randomHeraldPostId = heraldPosts.ElementAt(new Random().Next(0, heraldPosts.Count())).Id;

            var randomHeraldPost = heraldPosts.FirstOrDefault(hp => hp.Id == randomHeraldPostId);

            aircraft.AircraftRelatedHeralds.Add(randomHeraldPost!);

            heraldPosts.Where(hp => hp.Id == randomHeraldPostId).FirstOrDefault().AircraftId = aircraft.Id;
        }
        
        return heraldPosts.ToArray();
    }
}