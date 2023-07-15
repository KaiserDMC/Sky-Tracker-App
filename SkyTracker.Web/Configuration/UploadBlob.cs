namespace SkyTracker.Web.Configuration;

using Azure.Storage.Blobs;

public static class UploadBlob
{
    public static async Task UploadFromFileAsync(BlobContainerClient containerClient, string localFilePath)
    {
        string fileName = Path.GetFileName(localFilePath);
        BlobClient blobClient = containerClient.GetBlobClient(fileName);

        await blobClient.UploadAsync(localFilePath, true);
    }
}