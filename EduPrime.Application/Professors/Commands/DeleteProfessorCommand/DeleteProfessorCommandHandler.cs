using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Professors;

namespace EduPrime.Application.Professors.Commands
{
    /// <summary>
    /// Delete professor command handler
    /// </summary>
    public class DeleteProfessorCommandHandler : IRequestHandler<DeleteProfessorCommand, ErrorOr<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteProfessorCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ErrorOr<string>> Handle(DeleteProfessorCommand request, CancellationToken cancellationToken)
        {
            var professorDB = await _unitOfWork.ProfessorRepository.GetByIdAsync(request.id);
            if (professorDB is null)
            {
                return ProfessorErrors.ProfessorWithIdDoesNotExist(request.id);
            }

            try
            {
                await _unitOfWork.ProfessorRepository.Delete(professorDB.Id);
                await _unitOfWork.SaveChangesAsync();

                return "The resource has been deleted successfully";
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while deleting the resource.");
            }
        }
    }
}
