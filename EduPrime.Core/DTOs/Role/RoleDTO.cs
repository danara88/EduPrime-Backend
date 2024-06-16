using EduPrime.Core.DTOs.Permission;

namespace EduPrime.Core.DTOs.Role
{
    public class RoleDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<PermissionDTO> Permissions { get; set; }
    }
}
