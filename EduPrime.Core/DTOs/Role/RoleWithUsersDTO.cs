using EduPrime.Core.DTOs.User;

namespace EduPrime.Core.DTOs.Role
{
    public class RoleWithUsersDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<UserDTO> Users { get; set; }
    }
}
