namespace SkyTracker.Data.Models;

using Microsoft.AspNetCore.Identity;

/// <summary>
/// Represents a user in the identity system. Extends the IdentityUser class from Microsoft.AspNetCore.Identity
/// Changes the type of the primary key from string to Guid. Adds fields used for soft-deleting and profile pictures.
/// </summary>

public class ApplicationUser : IdentityUser<Guid>
{
    public ApplicationUser()
    {
        this.Id = Guid.NewGuid();
    }

    public bool IsDeleted { get; set; }

    public string? OriginalUsername { get; set; }

    public string? ProfilePictureUrl { get; set; }
}