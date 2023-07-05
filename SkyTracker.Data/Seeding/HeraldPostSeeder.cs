﻿using System.Globalization;

namespace SkyTracker.Data.Seeding;

using Newtonsoft.Json;

using Models;
using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

public class HeraldPostSeeder
{
    internal HeraldPost[] GenerateHeraldPosts()
    {
        ICollection<HeraldPost>? heraldPosts;

        // Specify the folder name relative to the current directory
        string relativePath = @"..\SkyTracker.Data\SampleData\modified_avherald.json";
        string fullPath = Path.GetFullPath(relativePath);

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

        return heraldPosts.ToArray();
    }
}