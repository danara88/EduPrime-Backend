using EduPrime.Application.Common.Interfaces;
using EduPrime.Application.Professors.Interfaces;

namespace EduPrime.Application.Professors.Services
{
    /// <summary>
    /// Professor service implementation
    /// </summary>
    public class ProfessorService : IProfessorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProfessorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Method to valdiate if the professor ids are valid
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
