using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.User
{
    public class LogInUserDTO
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
