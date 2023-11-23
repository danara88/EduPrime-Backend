using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Entities;

namespace EduPrime.Application.Roles.Interfaces
{
    /// <summary>
    /// Role repository interface
    /// </summary>
    public interface IRoleRepository : IBaseRepository<Role>
    {
        Task<Role> GetPrimaryRole();

        Task<Role> GetAdminRole();

        Task<Role> GetStandardRole();

        Task<Role> GetGuestRole();

        Task<Role> GetByIdWithUsersAsync(int id);

        Task<bool> ExistsAnyRoleAsync(string name);

        Task<bool> ExistsAnyRoleAsync(int id);
    }
}
