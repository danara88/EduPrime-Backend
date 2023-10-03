using EduPrime.Core.Entities;

namespace EduPrime.Infrastructure.Security
{
    /// <summary>
    /// JWT Factory interface
    /// </summary>
    public interface IJwtFactory
    {
        string GenerateJwtToken(User user);
    }
}
