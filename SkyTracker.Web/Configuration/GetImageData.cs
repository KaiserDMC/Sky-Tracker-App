namespace SkyTracker.Web.Configuration;

using Azure.Storage.Blobs;

/// <summary>
/// Calls the DownloadFromAzureStorage class to download the images from Azure Storage.
/// </summary>

public static class GetImageData
{
    public static async Task GetImageDataFromAzureAsync(BlobServiceClient blobServiceClient, IWebHostEnvironment hostingEnvironment)
    {
        var downloadFromAzureStorage = new DownloadFromAzureStorage(blobServiceClient, hostingEnvironment);
        await downloadFromAzureStorage.InitiateDownload();
    }
}