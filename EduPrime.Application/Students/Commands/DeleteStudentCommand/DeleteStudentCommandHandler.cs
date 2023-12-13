using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Delete student command handler
    /// </summary>
    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteStudentCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var studentDB = await _unitOfWork.StudentRepository.GetByIdAsync(request.id);
            if (studentDB is null)
            {
                throw new NotFoundException($"The student with id {request.id} does not exist.");
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
