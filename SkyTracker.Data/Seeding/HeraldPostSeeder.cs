namespace SkyTracker.Data.Seeding;

using Newtonsoft.Json;

using Models;

public class HeraldPostSeeder
{
    internal HeraldPost[] GenerateHeraldPosts()
    {
        ICollection<HeraldPost> heraldPosts = new HashSet<HeraldPost>();

        // Specify the folder name relative to the current directory
        string folderName = "SampleData";
        string folderPath = Path.Combine("../../../", folderName);

        string json = File.ReadAllText($"{folderPath}/combined_data_avherald.json");
        heraldPosts = JsonConvert.DeserializeObject<HashSet<HeraldPost>>(json);

        return heraldPosts.ToArray();
    }
}