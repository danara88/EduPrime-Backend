using System.ComponentModel.DataAnnotations;

namespace EduPrime.Core.DTOs.User
{
    public class UserDTO
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }
    }
}
