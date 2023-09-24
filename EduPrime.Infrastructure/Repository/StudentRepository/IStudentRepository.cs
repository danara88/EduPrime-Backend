using EduPrime.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EduPrime.Infrastructure.Repository
{
    /// <summary>
    /// Student repository interface
    /// </summary>
    public interface IStudentRepository : IBaseRepository<Student>
    {
        Task<List<Student>> GetStudentsWithAssignmentsAsync();

        Task<Student> GetStudentWithAssignmentsAsync(int id);

        Task<bool> ExistsAnyStudent(int id);
    }
}
