using EduPrime.Application.Users.Interfaces;
using EduPrime.Core.Entities;
using EduPrime.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EduPrime.Infrastructure.Repository
{
    /// <summary>
    /// User repository implementation
    /// </summary>
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Method to get a user by id with assigned role
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<User> GetByIdWithAssignedRoleAsync(int id)
        {
            return await _entity
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        /// <summary>
        /// Method to get a user by verification token
        /// </summary>
        /// <param name="verificationToken"></param>
        /// <returns></returns>
        public async Task<User> GetByVerificationTokenAsync(string verificationToken)
        {
            return await _entity.FirstOrDefaultAsync(u => u.VerificationToken == verificationToken);
        }

        /// <summary>
        /// Method to get a user by email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<User> GetUserByEmail(string email)
        {
            return await _entity
                .Include(u => u.Role)
                .ThenInclude(r => r.PermissionsRoles)
                .ThenInclude(pr => pr.Permission)
                .FirstOrDefaultAsync(u => u.Email == email);
        }

        /// <summary>
        /// Method to check if the input email already exists
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<bool> UserEmailExistsAsync(string email)
        {
            return await _entity.AnyAsync(u => u.Email.ToLower() == email.ToLower());
        }
    }
}
