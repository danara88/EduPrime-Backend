namespace EduPrime.Infrastructure.AzureServices
{
    /// <summary>
    /// Blob storage service interface
    /// </summary>
    public interface IBlobStorageService
    {
        Task<string> UploadFileBlobAsync(string fileName, string fileBase64, string containerName);

        Task DownloadBlobAsync(string containerName,  string blobName, string downloadPath);

        Task<Stream> DownloadBlobInBrowserAsync(string containerName, string blobName);
    }
}
