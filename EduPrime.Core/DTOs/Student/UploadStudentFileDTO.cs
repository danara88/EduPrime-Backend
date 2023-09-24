using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Student
{
    public class UploadStudentFileDTO
    {
        [Required]
        public string fileBase64 { get; set; }
    }
}
