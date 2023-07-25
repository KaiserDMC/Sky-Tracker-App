using SkyTracker.Web.ViewModels.Home;

namespace SkyTracker.Services.Data.Interfaces;

public interface IHomeService
{
    Task<IEnumerable<HeraldNewsModel>> GetLatestHeraldNewsAsync();
}