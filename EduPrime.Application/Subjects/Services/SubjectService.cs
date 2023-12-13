using EduPrime.Application.Common.Interfaces;
using EduPrime.Application.Subjects.Interfaces;
using EduPrime.Core.Entities;

namespace EduPrime.Application.Subjects.Services
{
    /// <summary>
    /// Subject service implementation
    /// </summary>
    public class SubjectService : ISubjectService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubjectService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        /// <summary>
        /// Validates if subject ids are valid
        /// </summary>
        /// <param name="subjectIds"></param>
        /// <param name="student"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
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
