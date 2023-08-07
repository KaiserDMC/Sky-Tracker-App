namespace SkyTracker.Web.Configuration;

using Azure.Storage.Blobs;

using static Common.GeneralApplicationContants;

/// <summary>
/// Download all images from Azure Storage to local storage.
/// Used only once on application start to download all images from Azure Storage to local storage.
/// </summary>

public class DownloadFromAzureStorage
{
    private readonly BlobServiceClient _blobServiceClient;
    private readonly IWebHostEnvironment _hostingEnvironment;

    public DownloadFromAzureStorage(BlobServiceClient blobServiceClient, IWebHostEnvironment hostingEnvironment)
    {
        _blobServiceClient = blobServiceClient;
        _hostingEnvironment = hostingEnvironment;
    }

    public async Task InitiateDownload()
    {
        await DownloadDataAirport();
        await DownloadDataAircraft();
        await DownloadDataProfile();
        await DownloadDataStock();
        await DownloadDataErrors();
    }

    private async Task DownloadDataAirport()
    {
        BlobContainerClient blobAirport = _blobServiceClient.GetBlobContainerClient(AirportImagesContainerName);

        await foreach (var airportBlobItem in blobAirport.GetBlobsAsync())
        {
            string airportBlobName = airportBlobItem.Name;

            string localPath = Path.Combine(_hostingEnvironment.WebRootPath, AirportImagesBlobRelativePath,
                airportBlobName);

            BlobClient blob = blobAirport.GetBlobClient(airportBlobName);

            if (await blob.ExistsAsync())
            {
                await DownloadBlob.DownloadBlobToFileAsync(blob, localPath);
            }
        }
    }

    private async Task DownloadDataAircraft()
    {
        BlobContainerClient blobAircraft = _blobServiceClient.GetBlobContainerClient(AircraftImagesContainerName);


        await foreach (var aircraftBlobItem in blobAircraft.GetBlobsAsync())
        {
            string aircraftBlobName = aircraftBlobItem.Name;

            string localPath = Path.Combine(_hostingEnvironment.WebRootPath, AircraftImagesBlobRelativePath,
                aircraftBlobName);

            BlobClient blob = blobAircraft.GetBlobClient(aircraftBlobName);

            if (await blob.ExistsAsync())
            {
                await DownloadBlob.DownloadBlobToFileAsync(blob, localPath);
            }
        }
    }

    private async Task DownloadDataProfile()
    {
        BlobContainerClient blobProfileImages = _blobServiceClient.GetBlobContainerClient(ProfileImagesContainerName);

        await foreach (var profileBlobItem in blobProfileImages.GetBlobsAsync())
        {
            string profileBlobName = profileBlobItem.Name;

            string localPath = Path.Combine(_hostingEnvironment.WebRootPath, ProfileImagesBlobRelativePath,
                profileBlobName);

            BlobClient blob = blobProfileImages.GetBlobClient(profileBlobName);

            if (await blob.ExistsAsync())
            {
                await DownloadBlob.DownloadBlobToFileAsync(blob, localPath);
            }
        }
    }

    private async Task DownloadDataStock()
    {
        BlobContainerClient blobStockImages = _blobServiceClient.GetBlobContainerClient(StockImagesContainerName);

        await foreach (var stockBlobItem in blobStockImages.GetBlobsAsync())
        {
            string stockBlobName = stockBlobItem.Name;

            string localPath = Path.Combine(_hostingEnvironment.WebRootPath, StockImagesBlobRelativePath,
                stockBlobName);

            BlobClient blob = blobStockImages.GetBlobClient(stockBlobName);

            if (await blob.ExistsAsync())
            {
                await DownloadBlob.DownloadBlobToFileAsync(blob, localPath);
            }
        }
    }

    private async Task DownloadDataErrors()
    {
        BlobContainerClient blobErrorImages = _blobServiceClient.GetBlobContainerClient(ErrorImagesContainerName);

        await foreach (var stockBlobItem in blobErrorImages.GetBlobsAsync())
        {
            string stockBlobName = stockBlobItem.Name;

            string localPath = Path.Combine(_hostingEnvironment.WebRootPath, ErrorImagesBlobRelativePath,
                stockBlobName);

            BlobClient blob = blobErrorImages.GetBlobClient(stockBlobName);

            if (await blob.ExistsAsync())
            {
                await DownloadBlob.DownloadBlobToFileAsync(blob, localPath);
            }
        }
    }
}