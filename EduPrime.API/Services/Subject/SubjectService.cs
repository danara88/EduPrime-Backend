using EduPrime.Infrastructure.Repository;

namespace EduPrime.API.Services
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
        /// Validates that each professor id exists in database
        /// </summary>
        /// <param name="professorIds"></param>
        /// <returns></returns>
        public async Task<(bool, int)> ValidProfessorIds(List<int> professorIds)
        {
            int invalidProfessorId = 0;
            bool isValidProfessorIds = true;

            foreach (var professorId in professorIds)
            {
                if (!(await _unitOfWork.ProfessorRepository.ExistsAnyProfessor(professorId)))
                {
                    isValidProfessorIds = false;
                    invalidProfessorId = professorId;
                    break;
                }
            }

            return (isValidProfessorIds, invalidProfessorId);
        }
    }
}
