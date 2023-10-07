using EduPrime.Core.Entities;
using EduPrime.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EduPrime.Infrastructure.Repository
{
    /// <summary>
    /// Role repository implementation
    /// </summary>
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        private const string primaryRoleName = "Primary";
        private const string adminRoleName = "Admin";
        private const string standardRoleName = "Standard";
        private const string guestRoleName = "Guest";

        public RoleRepository(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Gets the primary role
        /// </summary>
        /// <returns></returns>
        public async Task<Role> GetPrimaryRole() => await _entity.FirstOrDefaultAsync(r => r.Name.ToLower() == primaryRoleName.ToLower());

        /// <summary>
        /// Gets the admin role
        /// </summary>
        /// <returns></returns>
        public async Task<Role> GetAdminRole() => await _entity.FirstOrDefaultAsync(r => r.Name.ToLower() == adminRoleName.ToLower());

        /// <summary>
        /// Gets the standard role
        /// </summary>
        /// <returns></returns>
        public async Task<Role> GetStandardRole() => await _entity.FirstOrDefaultAsync(r => r.Name.ToLower() == standardRoleName.ToLower());

        /// <summary>
        /// Gets the guest role
        /// </summary>
        /// <returns></returns>
        public async Task<Role> GetGuestRole() => await _entity.FirstOrDefaultAsync(r => r.Name.ToLower() == guestRoleName.ToLower());
    }
}
