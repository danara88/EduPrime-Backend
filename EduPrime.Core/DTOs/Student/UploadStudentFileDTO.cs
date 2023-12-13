using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Student
{
    public class UploadStudentFileDTO
    {
        [Required]
        public int studentId { get; set; }

        [Required]
        public string fileBase64 { get; set; }
    }
}
