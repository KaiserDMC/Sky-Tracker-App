namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;

public class HeraldPost
{
    public HeraldPost()
    {
        this.Id = Guid.NewGuid();
    } 
    
    [Key]
    public Guid Id { get; set; }

    [Required]
    [JsonProperty("Occurrence")]
    public string Occurrence { get; set; } = null!;

    [Required]
    [JsonProperty("title")]
    public string TypeOccurence { get; set; } = null!;

    [Required]
    [JsonProperty("headline_avherald")]
    public string Details { get; set; } = null!;
}