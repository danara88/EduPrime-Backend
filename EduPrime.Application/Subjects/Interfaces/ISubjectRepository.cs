using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Entities;

namespace EduPrime.Application.Subjects.Interfaces
{
    /// <summary>
    /// Subject repository interface
    /// </summary>
    public interface ISubjectRepository : IBaseRepository<Subject>
    {
        Task<List<Subject>> GetSubjectsWithProfessorsAsync();

        Task<Subject> GetSubjectWithProfessorsAsync(int id);

        Task<bool> ExistsAnySubject(string name);

        Task<bool> ExistsAnySubject(int id);
    }
}
