namespace SkyTracker.Web.Infrastructure.Extensions;

using System.Security.Claims;

/// <summary>
/// Get user id from ClaimsPrincipal.
/// </summary>

public static class ClaimsPrincipalExtensions
{
    public static string? GetId(this ClaimsPrincipal user)
    {
        return user.FindFirst(ClaimTypes.NameIdentifier).Value;
    }
}