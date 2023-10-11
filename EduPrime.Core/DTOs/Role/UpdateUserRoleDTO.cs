using EduPrime.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.Role
{
    public class UpdateUserRoleDTO
    {
        [Required, Range(0, int.MaxValue)]
        public int RoleId { get; set; }

        [Required, Range(0, int.MaxValue)]
        public int UserId { get; set; }
    }
}
