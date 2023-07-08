namespace SkyTracker.Services.Data.Interfaces;

using System.Collections.Generic;
using System.Threading.Tasks;

using Web.ViewModels.Flight;

public interface IFlightService
{
    Task<IEnumerable<FlightAllViewModel>> GetAllFlightsAsync();

    Task<IEnumerable<FlightAllViewModel>> GetAllFlightsSortedByFlightIdDescAsync();

    Task<IEnumerable<FlightAllViewModel>> GetAllFlightsSortedByArpAscAsync();

    Task<IEnumerable<FlightAllViewModel>> GetAllFlightsSortedByArpDescAsync();

    Task<FlightDetailsViewModel> GetFlightDetailsByIdAsync(string flightId);
}