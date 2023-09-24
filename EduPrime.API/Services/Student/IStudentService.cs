using EduPrime.Core.Entities;

namespace EduPrime.API.Services
{
    /// <summary>
    /// Student service interface
    /// </summary>
    public interface IStudentService
    {
        Task<(bool, string)> ValidateSubjectIds(List<int> subjectIds, Student student);
    }
}
