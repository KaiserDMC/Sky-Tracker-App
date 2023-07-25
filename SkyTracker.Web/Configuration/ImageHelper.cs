using Azure.Storage.Blobs;

namespace SkyTracker.Web.Configuration;

using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

using Microsoft.AspNetCore.Http;

using static Common.GeneralApplicationContants;

public static class ImageHelper
{
    private static BlobServiceClient _blobServiceClient;

    public static void Initialize(BlobServiceClient blobServiceClient)
    {
        _blobServiceClient = blobServiceClient;
    }

    public static async Task<string> UploadAirportPicture(IFormFile file, string iata, string webRootPath)
    {
        if (file == null || file.Length == 0)
        {
            return string.Empty;
        }

        var filePath = Path.Combine(webRootPath, "temp", iata.ToLower() + ".jpg");

        using (var image = Image.FromStream(file.OpenReadStream(), true, true))

        using (var newImage = new Bitmap(image))
        {
            SaveFileLocal(filePath, newImage);
        }

        return filePath;
    }

    public static async Task<string> UploadAircraftPicture(IFormFile file, string registration, string webRootPath)
    {
        if (file == null || file.Length == 0)
        {
            return string.Empty;
        }

        var filePath = Path.Combine(webRootPath, "temp", registration.ToLower() + ".jpg");

        using (var image = Image.FromStream(file.OpenReadStream(), true, true))

        using (var newImage = new Bitmap(image))
        {
            SaveFileLocal(filePath, newImage);
        }

        return filePath;
    }

    public static async Task<string> UploadProfilePicture(IFormFile file, string username, string webRootPath)
    {
        if (file == null || file.Length == 0)
        {
            return string.Empty;
        }

        var filePath = Path.Combine(webRootPath, "temp", username.ToLower() + ".jpg");

        using (var image = Image.FromStream(file.OpenReadStream(), true, true))

        using (var newImage = new Bitmap(image))
        {
            SaveFileLocal(filePath, newImage);
        }

        return filePath;
    }

    public static void SaveFileLocal(string filePath, Bitmap newImage)
    {
        using (var stream = new MemoryStream())
        {
            newImage.Save(stream, ImageFormat.Jpeg);

            var imageBytes = stream.ToArray();

            using (var str = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.Write, 4096))
            {
                str.Write(imageBytes, 0, imageBytes.Length);
            }
        }
    }

    public static void SynchronizeAirportImages(string webRootPath, string airportIata)
    {
        string localPath = Path.Combine(webRootPath, "temp", airportIata.ToLower() + ".jpg");

        if (File.Exists(localPath))
        {
            File.Delete(localPath);
        }

        BlobContainerClient blobAirport = _blobServiceClient.GetBlobContainerClient(AirportImagesContainerName);
        BlobClient blob = blobAirport.GetBlobClient(airportIata.ToLower() + ".jpg");

        string downloadPath = Path.Combine(webRootPath, AirportImagesBlobRelativePath, airportIata.ToLower() + ".jpg");

        DownloadBlob.DownloadBlobToFileAsync(blob, downloadPath).Wait();
    }

    public static void SynchronizeProfileImages(string webRootPath, string username)
    {
        string localPath = Path.Combine(webRootPath, "temp", username.ToLower() + ".jpg");

        if (File.Exists(localPath))
        {
            File.Delete(localPath);
        }

        BlobContainerClient blobProfilePictures = _blobServiceClient.GetBlobContainerClient(ProfileImagesContainerName);
        BlobClient blob = blobProfilePictures.GetBlobClient(username.ToLower() + ".jpg");

        string downloadPath = Path.Combine(webRootPath, ProfileImagesBlobRelativePath, username.ToLower() + ".jpg");

        DownloadBlob.DownloadBlobToFileAsync(blob, downloadPath).Wait();
    }

    public static async Task DeleteAirportImages(string webRootPath, string[] airportIataArray)
    {
        foreach (var airportIata in airportIataArray)
        {
            string localPath = Path.Combine(webRootPath, AirportImagesBlobRelativePath, airportIata.ToLower() + ".jpg");

            if (File.Exists(localPath))
            {
                File.Delete(localPath);
            }

            BlobContainerClient blobAirport = _blobServiceClient.GetBlobContainerClient(AirportImagesContainerName);
            BlobClient blob = blobAirport.GetBlobClient(airportIata.ToLower() + ".jpg");

            if (await blob.ExistsAsync())
            {
                await blob.DeleteIfExistsAsync();
            }
        }
    }

    public static void SynchronizeAircraftImages(string webRootPath, string aircraftRegistration)
    {
        string localPath = Path.Combine(webRootPath, "temp", aircraftRegistration.ToLower() + ".jpg");

        if (File.Exists(localPath))
        {
            File.Delete(localPath);
        }

        BlobContainerClient blobAirport = _blobServiceClient.GetBlobContainerClient(AircraftImagesContainerName);
        BlobClient blob = blobAirport.GetBlobClient(aircraftRegistration.ToLower() + ".jpg");

        string downloadPath = Path.Combine(webRootPath, AircraftImagesBlobRelativePath, aircraftRegistration.ToLower() + ".jpg");

        DownloadBlob.DownloadBlobToFileAsync(blob, downloadPath).Wait();
    }

    public static async Task DeleteAircraftImages(string webRootPath, string[] aircraftRegistrationArray)
    {
        foreach (var aircraftRegistration in aircraftRegistrationArray)
        {
            string localPath = Path.Combine(webRootPath, AircraftImagesBlobRelativePath, aircraftRegistration.ToLower() + ".jpg");

            if (File.Exists(localPath))
            {
                File.Delete(localPath);
            }

            BlobContainerClient blobAirport = _blobServiceClient.GetBlobContainerClient(AircraftImagesContainerName);
            BlobClient blob = blobAirport.GetBlobClient(aircraftRegistration.ToLower() + ".jpg");

            if (await blob.ExistsAsync())
            {
                await blob.DeleteIfExistsAsync();
            }
        }
    }
}