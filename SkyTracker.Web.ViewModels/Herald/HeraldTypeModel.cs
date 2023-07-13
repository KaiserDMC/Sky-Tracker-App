namespace SkyTracker.Web.ViewModels.Herald;

using Enums;

public class HeraldTypeModel
{
    public int Id { get; set; }

    public HeraldType Type { get; set; }

    public string Name { get; set; } = null!;
}