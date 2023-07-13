﻿namespace SkyTracker.Services.Data.Interfaces;

using Microsoft.AspNetCore.Mvc;

using SkyTracker.Web.ViewModels.Flight;

using Web.ViewModels.Herald;

public interface IHeraldService
{
    Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsAsync();
    Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsSortedByDateAscAsync();
    Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsSortedByTypeAscAsync();
    Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsSortedByTypeDescAsync();

    Task<HeraldDetailsViewModel> GetDetailsById(string occurrenceId);

    Task<IEnumerable<HeraldTypeModel>> GetHeraldTypeAsync();

    Task AddHeraldAsync(HeraldFormModel model);

    Task<HeraldFormModel> GetHeraldbyIdAsync(string heraldId);

    Task EditHeraldAsync(string heraldId, HeraldFormModel model);

    Task DeleteHeraldAsync(string[] heraldIds);

    Task<IEnumerable<HeraldAllViewModel>> GetDeletedHeraldsAsync();
}