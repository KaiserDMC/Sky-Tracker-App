namespace SkyTracker.Data.Seeding;

using Newtonsoft.Json;

using Models;

public class HeraldPostSeeder
{
    internal HeraldPost[] GenerateHeraldPosts()
    {
        ICollection<HeraldPost>? heraldPosts;

        // Specify the folder name relative to the current directory
        string relativePath = @"..\SkyTracker.Data\SampleData\combined_data_avherald.json";
        string fullPath = Path.GetFullPath(relativePath);

        string json = File.ReadAllText(fullPath);
        heraldPosts = JsonConvert.DeserializeObject<HashSet<HeraldPost>>(json);

        return heraldPosts.ToArray();
    }
}