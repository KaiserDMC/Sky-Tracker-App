namespace SkyTracker.Common;

using System.IO;

/// <summary>
/// General application constants.
/// </summary>

public static class GeneralApplicationContants
{
    public const string YearCreated = "2023";

    public const int DefaultStartPagePagination = 1;
    
    public const int DefaultListEntitiesPerPage = 10;

    public const int DefaultAdminListEntitiesPerPage = 10;

    public const string AircraftImagesContainerName = "aircraft-images";
    public static readonly string AircraftImagesBlobRelativePath = Path.Combine("azure", "blob-aircraft");

    public const string AirportImagesContainerName = "airport-images";
    public static readonly string AirportImagesBlobRelativePath = Path.Combine("azure", "blob-airports");

    public const string StockImagesContainerName = "stock-images";
    public static readonly string StockImagesBlobRelativePath = Path.Combine("azure", "blob-stock");

    public const string ProfileImagesContainerName = "profile-images";
    public static readonly string ProfileImagesBlobRelativePath = Path.Combine("azure", "blob-profile");

    public const string ErrorImagesContainerName = "error-images";
    public static readonly string ErrorImagesBlobRelativePath = Path.Combine("azure", "blob-error");

    public const string DevAndTestingAdminEmail = "admin@sky-tracker.info";
    public const string DevAndTestingModeratorEmail = "moderator@sky-tracker.info";
}