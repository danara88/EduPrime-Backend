using EduPrime.Core.Entities;
using EduPrime.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EduPrime.Infrastructure.Repository
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Get all students including their assignments
        /// </summary>
        /// <returns></returns>
        public async Task<List<Student>> GetStudentsWithAssignmentsAsync()
        {
            var studentsWithAssignments = await _entity
                .Include(s => s.StudentsSubjects)
                .ThenInclude(ss => ss.Subject)
                .ToListAsync();

            return studentsWithAssignments;
        }

        /// <summary>
        /// Get a student by id including the assignments
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Student> GetStudentWithAssignmentsAsync(int id)
        {
            var studentWithAssignments = await _entity
                 .Include(s => s.StudentsSubjects)
                 .ThenInclude(ss => ss.Subject)
                 .FirstOrDefaultAsync(s => s.Id == id);

            return studentWithAssignments;
        }

        /// <summary>
        /// Verifies if there is an existing student by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> ExistsAnyStudent(int id)
        {
            return await _entity.AnyAsync(x => x.Id == id);
        }
    }
}
