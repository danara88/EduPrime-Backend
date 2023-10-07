using EduPrime.Core.DTOs.Role;

namespace EduPrime.Core.DTOs.User
{
    public class UserDTO
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public RoleDTO Role { get; set; }
    }
}
