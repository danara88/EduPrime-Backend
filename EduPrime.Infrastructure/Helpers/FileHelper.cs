using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Entities;

namespace EduPrime.Infrastructure.Helpers
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

        /// <summary>
        /// Generates a unique file name for employees
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="employee"></param>
        /// <returns></returns>
        public string GenerateEmployeeFileName(string fileName, Employee employee)
        {
            string guid = Guid.NewGuid().ToString();
            string documentName = $"{guid}{employee.Name}{employee.Surname}{fileName}";
            return documentName.Replace(" ", "");
        }

        /// <summary>
        /// Generates a unique file name for students
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="student"></param>
        /// <returns></returns>
        public string GenerateStudentFileName(string fileName, Student student)
        {
            string guid = Guid.NewGuid().ToString();
            string documentName = $"{guid}{student.Name}{student.Surname}{fileName}";
            return documentName.Replace(" ", "");
        }
    }
}
