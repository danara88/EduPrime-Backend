using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Employee
{
    public class UpdateEmployeeDTO
    {
        [Required, Range(0, int.MaxValue)]
        public int Id { get; set; }

        [Required, MinLength(4), MaxLength(100)]
        public string Name { get; set; }

        [Required, MinLength(4), MaxLength(100)]
        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required, RegularExpression("^([0-9]{10})$")]
        public string PhoneNumber { get; set; }

        public string? PictureURL { get; set; }

        public string? RfcDocument { get; set; }
    }
}
