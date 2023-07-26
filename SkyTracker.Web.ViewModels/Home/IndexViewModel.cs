namespace SkyTracker.Web.ViewModels.Home;

public class IndexViewModel
{
    public string? StatusMessage { get; set; }

    public IEnumerable<HeraldNewsModel> NewsItems { get; set; } = new List<HeraldNewsModel>();
}