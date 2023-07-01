namespace SkyTracker.Data.Seeding.DTOs;

using Newtonsoft.Json;

public class RunwaySeedDTO
{
    [JsonProperty("designation1")]
    public string RunwayDesignatorOne { get; set; } = null!;

    [JsonProperty("designation2")]
    public string RunwayDesignatorTwo { get; set; } = null!;
}