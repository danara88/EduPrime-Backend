using EduPrime.Core.Entities;

namespace EduPrime.Application.Common.Interfaces
{
    /// <summary>
    /// File helper interface
    /// </summary>
    public interface IFileHelper
    {
        bool IsValidBase64Pdf(string base64String);

        (bool, string) IsValidBase64Image(string base64String);

        string GenerateEmployeeFileName(string fileName, Employee employee);

        string GenerateStudentFileName(string fileName, Student student);
    }
}
