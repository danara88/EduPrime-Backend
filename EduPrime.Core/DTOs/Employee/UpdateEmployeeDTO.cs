using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Employee
{
    public class UpdateEmployeeDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string? PictureURL { get; set; }

        public string? RfcDocument { get; set; }
    }
}
