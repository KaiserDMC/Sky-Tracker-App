﻿namespace SkyTracker.Services.Data.Interfaces;

using Web.ViewModels.Aircraft;

public interface IAircraftService
{
    Task<IEnumerable<AircraftAllViewModel>> GetAllAircraftAsync();

    Task<AircraftDetailsViewModel> GetAircraftDetailsByIdAsync(string aircraftId);

    Task AddAircraftAsync(AircraftFormModel model);

    Task<AircraftFormModel> GetAircraftbyIdAsync(string aircraftId);

    Task EditAircraftAsync(string aircraftId, AircraftFormModel model);

    Task<List<string>> GetAircraftPictureIdsAsync(string[] aircraftIds);

    Task DeleteAircraftAsync(string[] aircraftIds);

    Task<IEnumerable<AircraftAllViewModel>> GetDeletedAircraftAsync();

    Task RepairAircraftAsync(string[] aircraftIds);

    Task<IEnumerable<AircraftAllViewModel>> GetTotaledAircraftAsync();
}