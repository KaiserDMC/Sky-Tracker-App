namespace SkyTracker.Web.ViewModels.AccountManagement;

public class ProfileDisplayModel
{
    public string UserId { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? ProfilePictureUrl { get; set; }
}