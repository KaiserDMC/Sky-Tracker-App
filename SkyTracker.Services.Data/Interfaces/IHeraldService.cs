namespace SkyTracker.Services.Data.Interfaces;

using Web.ViewModels.Herald;

public interface IHeraldService
{
    Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsAsync();
    Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsSortedByTypeAscAsync();
    Task<IEnumerable<HeraldAllViewModel>> GetAllHeraldsSortedByTypeDescAsync();
}