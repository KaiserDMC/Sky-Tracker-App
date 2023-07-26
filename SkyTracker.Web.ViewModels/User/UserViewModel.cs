namespace SkyTracker.Web.ViewModels.User;

public class UserViewModel
{
    public Guid Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }
}