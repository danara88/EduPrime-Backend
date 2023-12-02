using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Employee
{
    public class UploadEmployeeFileDTO
    {
        [Required]
        public int employeeId { get; set; }

        [Required]
        public string fileBase64 { get; set; }
    }
}
