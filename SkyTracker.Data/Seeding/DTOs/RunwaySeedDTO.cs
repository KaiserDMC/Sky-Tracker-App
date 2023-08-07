namespace SkyTracker.Data.Seeding.DTOs;

using Newtonsoft.Json;

/// <summary>
/// DTO for seeding Runways.
/// JSON properties used for deserialization are the same as the ones in the JSON file.
/// </summary>

public class RunwaySeedDto
{
    [JsonProperty("guid")]
    public string Guid { get; set; } = null!;

    [JsonProperty("designation1")]
    public string RunwayDesignatorOne { get; set; } = null!;

    [JsonProperty("designation2")]
    public string RunwayDesignatorTwo { get; set; } = null!;
}