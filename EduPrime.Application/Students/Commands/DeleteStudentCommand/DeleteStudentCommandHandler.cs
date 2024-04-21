using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Students;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Delete student command handler
    /// </summary>
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, ErrorOr<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteStudentCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ErrorOr<string>> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var studentDB = await _unitOfWork.StudentRepository.GetByIdAsync(request.id);
            if (studentDB is null)
            {
                return StudentErrors.StudentWithIdDoesNotExist(request.id);
            }

            try
            {
                await _unitOfWork.StudentRepository.Delete(studentDB.Id);
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
