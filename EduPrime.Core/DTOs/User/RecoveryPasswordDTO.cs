using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.User
{
    public class RecoveryPasswordDTO
    {
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
    }
}
