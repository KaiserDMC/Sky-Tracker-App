﻿namespace SkyTracker.Web.ViewModels.Herald;

public class HeraldAllViewModel
{
    public string OccurrenceId { get; set; }

    public string OccurrenceDate { get; set; } = null!;

    public string TypeOccurence { get; set; } = null!;

    public string Details { get; set; } = null!;
}