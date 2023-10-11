using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Role
{
    public class CreateRoleDTO
    {
        [Required, MinLength(3), MaxLength(100)]
        public string Name { get; set; }
    }
}
