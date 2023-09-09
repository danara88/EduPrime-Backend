using EduPrime.Core.Entities;
using EduPrime.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EduPrime.Infrastructure.Repository
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Verifies if a professor exists by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> ExistsAnyProfessor(int id)
        {
            return await _entity.AnyAsync(e => e.Id == id);
        }

        /// <summary>
        /// Gets all professors with employee data
        /// </summary>
        /// <returns></returns>
        public async Task<List<Professor>> GetProfessorsWithEmployeeAsync()
        {
            return await _entity
                .Include(p => p.Employee)
                .ToListAsync();
        }

        /// <summary>
        /// Get a professor with employee id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Professor> GetProfessorWithEmployeeAsync(int id)
        {
            return await _entity
                .Include(p => p.Employee)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
