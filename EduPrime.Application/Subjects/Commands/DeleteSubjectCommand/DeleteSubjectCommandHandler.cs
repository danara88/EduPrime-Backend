using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Subjects;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Delete subject command handler
    /// </summary>
    public class DeleteSubjectCommandHandler : IRequestHandler<DeleteSubjectCommand, ErrorOr<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteSubjectCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ErrorOr<string>> Handle(DeleteSubjectCommand request, CancellationToken cancellationToken)
        {
            var subjectDB = await _unitOfWork.SubjectRepository.GetByIdAsync(request.id);
            if (subjectDB is null)
            {
                return SubjectErrors.SubjectWithIdDoesNotExist(request.id);
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
