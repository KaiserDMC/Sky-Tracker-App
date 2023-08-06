namespace SkyTracker.Web.ViewModels.Herald;

public class HeraldDetailsViewModel
{
    public string OccurrenceId { get; set; } = null!;

    public string OccurrenceDate { get; set; } = null!;

    public string TypeOccurence { get; set; } = null!;

    public string Details { get; set; } = null!;

    public string? AircraftId { get; set; }
}