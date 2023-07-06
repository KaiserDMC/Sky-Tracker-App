namespace SkyTracker.Web.ViewModels.Aircraft;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AircraftDetailsViewModel
{
    public string Id { get; set; } = null!;

    public string? Registration { get; set; }

    public string? Equipment { get; set; }

    public string ImageUrl { get; set; } = null!;
}