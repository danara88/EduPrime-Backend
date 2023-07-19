using EduPrime.Core.Entities;

namespace EduPrime.Infrastructure.Repository
{
    /// <summary>
    /// Area repository interface
    /// </summary>
    public interface IAreaRepository : IBaseRepository<Area>
    {
        Task<bool> ExistsAnyArea(string name);

        Task<bool> ExistsAnyArea(int id);

        Task<List<Area>> GetAreasWithEmployeesAsync();
    }
}
