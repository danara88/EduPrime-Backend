using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Entities;

namespace EduPrime.Application.Students.Interfaces
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
