using EduPrime.Core.Entities;

namespace EduPrime.Infrastructure.Repository
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
