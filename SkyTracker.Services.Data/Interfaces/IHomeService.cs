namespace SkyTracker.Services.Data.Interfaces;

using Web.ViewModels.Home;

public interface IHomeService
{
    Task<IEnumerable<HeraldNewsModel>> GetLatestHeraldNewsAsync();
}