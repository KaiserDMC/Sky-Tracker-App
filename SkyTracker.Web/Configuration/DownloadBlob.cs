namespace SkyTracker.Web.Configuration;

using Azure.Storage.Blobs;

public static class DownloadBlob
{
    public static async Task DownloadBlobToFileAsync(BlobClient blobClient, string localFilePath)
    {
        await blobClient.DownloadToAsync(localFilePath);
    }
}