namespace SkyTracker.Common;

using System.IO;

public static class GeneralApplicationContants
{
    public const int DefaultAdminListEntitiesPerPage = 10;

    public const string AircraftImagesContainerName = "aircraft-images";
    public static readonly string AircraftImagesBlobRelativePath = Path.Combine("azure", "blob-aircraft");

    public const string AirportImagesContainerName = "airport-images";
    public static readonly string AirportImagesBlobRelativePath = Path.Combine("azure", "blob-airports");

    public const string StockImagesContainerName = "stock-images";
    public static readonly string StockImagesBlobRelativePath = Path.Combine("azure", "blob-stock");

    public const string ProfileImagesContainerName = "profile-images";
    public static readonly string ProfileImagesBlobRelativePath = Path.Combine("azure", "blob-profile");
}