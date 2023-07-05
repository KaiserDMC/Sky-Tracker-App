namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;

using Newtonsoft.Json;
using static SkyTracker.Common.DataModelsValidationConstants.HeraldPost;

public class HeraldPost
{
    [Key]
    [JsonProperty("guid")]
    public Guid Id { get; set; }

    [Required]
    [JsonProperty("Occurrence")]
    [DisplayFormat(DataFormatString = DateFormat)]
    public DateTime Occurrence { get; set; }

    [Required]
    [JsonProperty("title")]
    public string TypeOccurence { get; set; } = null!;

    [Required]
    [JsonProperty("headline_avherald")]
    public string Details { get; set; } = null!;
}