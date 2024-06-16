using EduPrime.Core.DTOs.User;

namespace EduPrime.Application.Common.Interfaces
{
    /// <summary>
    /// JWT Factory interface
    /// </summary>
    public interface IJwtFactory
    {
        string GenerateJwtToken(UserDTO userDTO);
    }
}
