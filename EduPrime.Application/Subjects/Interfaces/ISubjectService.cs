using EduPrime.Core.Entities;

namespace EduPrime.Application.Subjects.Interfaces
{
    /// <summary>
    /// Subject service interface
    /// </summary>
    public interface ISubjectService
    {
        Task<(bool, string)> ValidateSubjectIds(List<int> subjectIds, Student student);
    }
}
