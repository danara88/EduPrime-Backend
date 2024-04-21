using ErrorOr;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Application.Subjects.Interfaces;
using EduPrime.Core.Entities;
using EduPrime.Core.Subjects;

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
        public async Task<(bool, Error)> ValidateSubjectIds(List<int> subjectIds, Student student)
        {
            bool isValidSubjectIds = true;
            int studentCurrentSemester = (int)student.CurrentSemester;
            Error invalidReason = new Error();

            foreach (var subjectId in subjectIds)
            {
                var subject = await _unitOfWork.SubjectRepository.GetByIdAsync(subjectId);
                if (subject is null)
                {
                    isValidSubjectIds = false;
                    invalidReason = SubjectErrors.SubjectWithIdDoesNotExist(subjectId);
                    break;
                }
                int subjectAvailableSemester = (int)subject.AvailableSemester;
                if (studentCurrentSemester < subjectAvailableSemester)
                {
                    isValidSubjectIds = false;
                    invalidReason = SubjectErrors.SubjectNotAvailableDueToSemester(subjectId, subjectAvailableSemester);
                    break;
                }
            }

            return (isValidSubjectIds, invalidReason);
        }
    }
}
