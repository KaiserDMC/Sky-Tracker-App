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

    Task<IEnumerable<AirportCollectionViewModel>> GetAirportsCollectionAsync();

    Task<IEnumerable<AircraftCollectionViewModel>> GetAircraftsCollectionAsync();

    Task AddFlightAsync(FlightFormModel model);

    Task<FlightFormModel> GetFlightbyIdAsync(string flightId);

    Task EditFlightAsync(string flightId, FlightFormModel model);

    Task DeleteFlightAsync(string[] flightIds);

    Task<IEnumerable<FlightAllViewModel>> GetDeletedFlightsAsync();
}