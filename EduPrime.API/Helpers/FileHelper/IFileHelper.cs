namespace EduPrime.Api.Helpers
{
    /// <summary>
    /// File helper interface
    /// </summary>
    public interface IFileHelper
    {
        bool IsValidBase64Pdf(string base64String);

        (bool, string) IsValidBase64Image(string base64String);
    }
}
