namespace SkyTracker.Services.Data.Interfaces;

using SkyTracker.Web.ViewModels.Aircraft;

public interface IAircraftService
{
    Task<IEnumerable<AircraftAllViewModel>> GetAllAircraftAsync();

    Task<AircraftDetailsViewModel> GetAircraftDetailsByIdAsync(string aircraftId);
}