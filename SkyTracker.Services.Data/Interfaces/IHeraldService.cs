namespace SkyTracker.Services.Data.Interfaces;

using Microsoft.AspNetCore.Mvc;

using Web.ViewModels.Herald;

public interface IHeraldService
{
    Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsAsync();
    Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsSortedByDateAscAsync();
    Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsSortedByTypeAscAsync();
    Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsSortedByTypeDescAsync();

    Task<HeraldDetailsViewModel> GetDetailsById(string occurrenceId);
}