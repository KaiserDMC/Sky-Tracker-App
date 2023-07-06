namespace SkyTracker.Services.Data.Interfaces;

using System.Collections.Generic;
using System.Threading.Tasks;

using SkyTracker.Web.ViewModels.Flight;

public interface IFlightService
{
    Task<IEnumerable<FlightAllViewModel>> GetAllFlightsAsync();

    Task<IEnumerable<FlightAllViewModel>> GetAllFlightsSortedByFlightIdDescAsync();

    Task<IEnumerable<FlightAllViewModel>> GetAllFlightsSortedByArpAscAsync();

    Task<IEnumerable<FlightAllViewModel>> GetAllFlightsSortedByArpDescAsync();
}