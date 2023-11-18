using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.User
{
    public class ConfirmEmailDTO
    {
        [Required]
        public string Code { get; set; }
    }
}
