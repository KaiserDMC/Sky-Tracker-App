namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;

using static SkyTracker.Common.DataModelsValidationConstants.Airport;

public class Airport
{
    public Airport()
    {
        this.Id = Guid.NewGuid();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    [RegularExpression(CodeIATA)]
    public string IATA { get; set; } = null!;

    [RegularExpression(CodeICAO)]
    public string? ICAO { get; set; }

    public ICollection<Runway> Runways { get; set; } = new List<Runway>();

    public ICollection<Flight> Flights { get; set; } = new List<Flight>();
}