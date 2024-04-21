using AutoMapper;
using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Subjects;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Update subject command handler
    /// </summary>
    public class UpdateSubjectCommandHandler : IRequestHandler<UpdateSubjectCommand, ErrorOr<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateSubjectCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<string>> Handle(UpdateSubjectCommand request, CancellationToken cancellationToken)
        {
            var subjectDB = await _unitOfWork.SubjectRepository.GetByIdAsync(request.updateSubjectDTO.Id);
            if (subjectDB is null)
            {
                return SubjectErrors.SubjectWithIdDoesNotExist(request.updateSubjectDTO.Id);
            }

            request.updateSubjectDTO.Id = subjectDB.Id;
            _mapper.Map(request.updateSubjectDTO, subjectDB);

            try
            {
                await _unitOfWork.SaveChangesAsync();
                return "The resource has been updated successfully";
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while updating the resource.");
            }
        }
    }
}
