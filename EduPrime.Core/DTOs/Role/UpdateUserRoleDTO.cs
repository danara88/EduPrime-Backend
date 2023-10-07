using EduPrime.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Role
{
    public class UpdateUserRoleDTO
    {
        [Required]
        public int RoleId { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
