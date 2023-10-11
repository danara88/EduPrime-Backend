using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.User
{
    public class UpdateUserDTO
    {
        [Required, Range(1, int.MaxValue)]
        public int Id { get; set; }

        [Required, MinLength(3), MaxLength(100)]
        public string Name { get; set; }

        [Required, MinLength(3), MaxLength(200)]
        public string Surname { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
    }
}
