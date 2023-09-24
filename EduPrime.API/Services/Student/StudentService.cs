using EduPrime.Core.Entities;
using EduPrime.Infrastructure.Repository;

namespace EduPrime.API.Services
{
    /// <summary>
    /// Student service implementation
    /// </summary>
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Validates that each subject id exists in database
        /// </summary>
        /// <param name="subjectIds"></param>
        /// <returns></returns>
        public async Task<(bool, string)> ValidateSubjectIds(List<int> subjectIds, Student student)
        {
            bool isValidSubjectIds = true;
            int studentCurrentSemester = (int)student.CurrentSemester;
            string invalidReason = string.Empty;

            foreach (var subjectId in subjectIds)
            {
                var subject = await _unitOfWork.SubjectRepository.GetByIdAsync(subjectId);
                if (subject is null)
                {
                    isValidSubjectIds = false;
                    invalidReason = $"The subject with id {subjectId} does not exist.";
                    break;
                }
                int subjectAvailableSemester = (int)subject.AvailableSemester;
                if (studentCurrentSemester < subjectAvailableSemester)
                {
                    isValidSubjectIds = false;
                    invalidReason = $"The subject with id {subjectId} is only available for {subjectAvailableSemester}° semester students.";
                    break;
                }
            }

            return (isValidSubjectIds, invalidReason);
        }
    }
}
