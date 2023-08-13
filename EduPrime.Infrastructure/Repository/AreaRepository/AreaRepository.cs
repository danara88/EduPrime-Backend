using EduPrime.Core.Entities;
using EduPrime.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EduPrime.Infrastructure.Repository
{
    public class AreaRepository : BaseRepository<Area>, IAreaRepository
    {
        public AreaRepository(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Verifies if an Area already exists by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<bool> ExistsAnyArea(string name)
        {
            return await _entity.AnyAsync(a => a.Name == name);
        }

        /// <summary>
        /// Verifies if an Area already exists by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> ExistsAnyArea(int id)
        {
            return await _entity.AnyAsync(a => a.Id == id);
        }

        /// <summary>
        /// Gets areas with employees
        /// </summary>
        /// <returns></returns>
        public async Task<List<Area>> GetAreasWithEmployeesAsync() 
        {
            return await _entity
                .Include(area => area.Employees)
                .ToListAsync();
        }
    }
}
