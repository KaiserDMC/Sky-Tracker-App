namespace SkyTracker.Web.ViewModels.Admin;

using Aircraft;
using Airports;
using Flight;
using Herald;

public class AdminPanelViewModel
{
    public List<FlightAllViewModel> AllFlights { get; set; } = new List<FlightAllViewModel>();

    public List<AircraftAllViewModel> AllAircrafts { get; set; } = new List<AircraftAllViewModel>();

    public List<AirportsAllViewModel> AllAirports { get; set; } = new List<AirportsAllViewModel>();

    public List<HeraldAllViewModel> AllHeralds { get; set; } = new List<HeraldAllViewModel>();


}