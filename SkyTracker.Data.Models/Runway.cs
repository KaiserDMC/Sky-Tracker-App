namespace SkyTracker.Data.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static SkyTracker.Common.DataModelsValidationConstants.Runway;

public class Runway
{
    public Runway()
    {
        this.Id = Guid.NewGuid();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    [RegularExpression(Number)]
    public string RunwayNumber { get; set; }

    [Required]
    public double Length { get; set; }

    public double? Width { get; set; }

    public string? SurfaceType { get; set; }

    [Required, ForeignKey(nameof(Airport))]
    public string AirportId { get; set; } = null!;
    public Airport Airport { get; set; } = null!;
}