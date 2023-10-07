using EduPrime.Core.Entities;

namespace EduPrime.Infrastructure.Repository
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
    }
}
