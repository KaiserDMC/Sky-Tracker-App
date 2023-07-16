namespace SkyTracker.Services.Data.Interfaces;

using Web.ViewModels.Aircraft;

public interface IAircraftService
{
    Task<IEnumerable<AircraftAllViewModel>> GetAllAircraftAsync();

    Task<AircraftDetailsViewModel> GetAircraftDetailsByIdAsync(string aircraftId);

    Task AddAircraftAsync(AircraftFormModel model);

    Task<AircraftFormModel> GetAircraftbyIdAsync(string aircraftId);

    Task EditAircraftAsync(string aircraftId, AircraftFormModel model);

    Task DeleteAircraftAsync(string[] aircraftIds);

    Task<IEnumerable<AircraftAllViewModel>> GetDeletedAircraftAsync();
}