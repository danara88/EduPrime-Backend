using EduPrime.Core.Enums.Shared;

namespace EduPrime.Application.Common.Interfaces
{
    /// <summary>
    /// Blob storage service interface
    /// </summary>
    public interface IBlobStorageService
    {
        Task<string> UploadFileBlobAsync(string fileName, string fileBase64, AzureContainerEnum azureContainerEnum);

        Task DownloadBlobAsync(AzureContainerEnum azureContainerEnum,  string blobName, string downloadPath);

        Task<Stream> DownloadBlobInBrowserAsync(AzureContainerEnum azureContainerEnum, string blobName);
    }
}
