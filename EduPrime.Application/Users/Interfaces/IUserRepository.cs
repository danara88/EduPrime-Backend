using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Entities;

namespace EduPrime.Application.Users.Interfaces
{
    /// <summary>
    /// User repository interface
    /// </summary>
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<bool> UserEmailExistsAsync(string email);

        Task<User> GetUserByEmail(string email);

        Task<User> GetByIdWithAssignedRoleAsync(int id);

        Task<User> GetByVerificationTokenAsync(string verificationToken);
    }
}
