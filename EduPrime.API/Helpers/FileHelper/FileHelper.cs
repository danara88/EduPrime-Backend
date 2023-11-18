namespace EduPrime.Api.Helpers
{
    /// <summary>
    /// File helper implementation
    /// </summary>
    public class FileHelper : IFileHelper
    {
        /// <summary>
        /// Method to validate if a base64 string is a PDF
        /// </summary>
        /// <param name="base64String"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public (bool, string) IsValidBase64Image(string base64String)
        {
            var data = base64String.Substring(0, 5).ToLower();
            var validTerms = new string[] { "ivbor", "/9j/4" };
            var isValidImage = false;
            var fileExtension = "";
            if (validTerms.Contains(data))
            {
                fileExtension = data switch
                {
                    "ivbor" => "png",
                    "/9j/4" => "jpg",
                    _ => "jpg"
                };
                isValidImage = true;
            }
            return (isValidImage, fileExtension);
        }

        /// <summary>
        /// Method to validate is a base64 string is an image
        /// </summary>
        /// <param name="base64String"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool IsValidBase64Pdf(string base64String)
        {
            var data = base64String.Substring(0, 5).ToLower();
            return data == "jvber" ? true : false;
        }
    }
}
