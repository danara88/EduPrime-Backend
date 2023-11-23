using EduPrime.Application.Subjects.Interfaces;
using EduPrime.Core.Entities;
using EduPrime.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EduPrime.Infrastructure.Repository
{
    public class SubjectRepository : BaseRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Get all the subjects with professors
        /// </summary>
        /// <returns></returns>
        public async Task<List<Subject>> GetSubjectsWithProfessorsAsync()
        {
            return await _entity
                .Include(s => s.ProfessorsSubjects)
                .ThenInclude(ps => ps.Professor)
                .ThenInclude(p => p.Employee)
                .ToListAsync();
        }

        /// <summary>
        /// Gets a subject with professors
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Subject> GetSubjectWithProfessorsAsync(int id)
        {
            return await _entity
                .Include(s => s.ProfessorsSubjects)
                .ThenInclude(ps => ps.Professor)
                .ThenInclude(p => p.Employee)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        /// <summary>
        /// Verifies if there is an existing subject by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<bool> ExistsAnySubject(string name)
        {
            return await _entity.AnyAsync(x => x.Name == name);
        }

        /// <summary>
        /// Verifies if there is an existing subject by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> ExistsAnySubject(int id)
        {
            return await _entity.AnyAsync(x => x.Id == id);
        }
    }
}
