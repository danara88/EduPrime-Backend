using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Delete subject command handler
    /// </summary>
    public class DeleteSubjectCommandHandler : IRequestHandler<DeleteSubjectCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteSubjectCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(DeleteSubjectCommand request, CancellationToken cancellationToken)
        {
            var subjectDB = await _unitOfWork.SubjectRepository.GetByIdAsync(request.id);
            if (subjectDB is null)
            {
                throw new NotFoundException($"The subject with id {request.id} does not exist.");
            }

            try
            {
                await _unitOfWork.SubjectRepository.Delete(subjectDB.Id);
                await _unitOfWork.SaveChangesAsync();

                return "The resource has been deleted successfully"; ;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while deleting the resource.");
            }
        }
    }
}
