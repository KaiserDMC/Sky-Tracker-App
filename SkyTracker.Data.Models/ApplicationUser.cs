namespace SkyTracker.Data.Models;

using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser<Guid>
{
    public ApplicationUser()
    {
        this.Id = Guid.NewGuid();
    }

    public bool IsDeleted { get; set; }

    public string? ProfilePictureUrl { get; set; }
}