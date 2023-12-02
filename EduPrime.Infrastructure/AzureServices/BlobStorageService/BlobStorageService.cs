using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Enums.Shared;
using Microsoft.Extensions.Options;

namespace EduPrime.Infrastructure.AzureServices
{
    /// <summary>
    /// Blob storag service
    /// </summary>
    public class BlobStorageService : IBlobStorageService
    {
        private readonly AzureSettings _azureSettings;

        public BlobStorageService(IOptions<AzureSettings> azureSettings)
        {
            _azureSettings = azureSettings.Value;
        }

        /// <summary>
        /// Method to upload a file to storage
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="fileBase64"></param>
        /// <param name="containerName"></param>
        /// <returns></returns>
        public async Task<string> UploadFileBlobAsync(string fileName, string fileBase64, AzureContainerEnum azureContainerEnum)
        {
            try
            {
                var blobServiceClient = new BlobServiceClient(_azureSettings.StorageAccountKey);
                var containerName = GetContainerName(azureContainerEnum);
                var containerClient = blobServiceClient.GetBlobContainerClient(containerName);
                var blobClient = containerClient.GetBlobClient(fileName);

                string fileContentType = GetContentType(fileName);

                byte[] bytes = Convert.FromBase64String(fileBase64);

                var options = new BlobUploadOptions
                {
                    HttpHeaders = new BlobHttpHeaders { ContentType = fileContentType }
                };

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    await blobClient.UploadAsync(ms, options);
                }

                return blobClient.Uri.AbsoluteUri;
            }
            catch (Exception)
            {
                throw new Exception("Error while downloading the file.");
            }
        }

        /// <summary>
        /// Method to download a file into a specific path
        /// </summary>
        /// <param name="containerName"></param>
        /// <param name="blobName"></param>
        /// <param name="downloadPath"></param>
        /// <returns></returns>
        public async Task DownloadBlobAsync(AzureContainerEnum azureContainerEnum, string blobName, string downloadPath)
        {
            try
            {
                var blobServiceClient = new BlobServiceClient(_azureSettings.StorageAccountKey);
                var containerName = GetContainerName(azureContainerEnum);
                var containerClient = blobServiceClient.GetBlobContainerClient(containerName);
                var blobClient = containerClient.GetBlobClient(blobName);

                BlobDownloadInfo blobDownloadInfo = await blobClient.DownloadAsync();

                using (FileStream fs = File.OpenWrite(downloadPath))
                {
                    await blobDownloadInfo.Content.CopyToAsync(fs);
                    fs.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("Error while downloading the file.");
            }
        }

        /// <summary>
        /// Method to donwload a file into browser
        /// </summary>
        /// <param name="containerName"></param>
        /// <param name="blobName"></param>
        /// <returns></returns>
        public async Task<Stream> DownloadBlobInBrowserAsync(AzureContainerEnum azureContainerEnum, string blobName)
        {
            try
            {
                var blobServiceClient = new BlobServiceClient(_azureSettings.StorageAccountKey);
                var containerName = GetContainerName(azureContainerEnum);
                var containerClient = blobServiceClient.GetBlobContainerClient(containerName);
                var blobClient = containerClient.GetBlobClient(blobName);
           
                BlobDownloadInfo blobDownloadInfo = await blobClient.DownloadAsync();
                return blobDownloadInfo.Content;
            }
            catch (Exception)
            {
                throw new Exception("Error while downloading the file.");
            }
        }

        /// <summary>
        /// Private method to get file content type
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private string GetContentType(string fileName)
        {
            var fileExtension = Path.GetExtension(fileName).ToLowerInvariant();
            string result = fileExtension switch
            {
                ".pdf" => "application/pdf",
                ".png" => "image/png",
                ".jpg" => "image/jpg",
                _ => ""
            };
            return result;
        }

        /// <summary>
        /// Private method in charge of returning container names
        /// </summary>
        /// <param name="azureContainerEnum"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private string GetContainerName(AzureContainerEnum azureContainerEnum)
        {
            return azureContainerEnum switch
            {
                AzureContainerEnum.EmployeesRFCs => _azureSettings.EmployeesRfcsContainer,
                AzureContainerEnum.EmployeesPictures => _azureSettings.EmployeesPicturesContainer,
                AzureContainerEnum.StudentsPictures => _azureSettings.StudentsPicturesContainer,
                _ => throw new Exception("The container does not exist.")
            };
        }
    }
}

