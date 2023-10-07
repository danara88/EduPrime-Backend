using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Role
{
    public class CreateRoleDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
