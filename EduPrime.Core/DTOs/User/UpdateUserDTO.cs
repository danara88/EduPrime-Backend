using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.User
{
    public class UpdateUserDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
    }
}
