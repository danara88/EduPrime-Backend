using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Update subject command handler
    /// </summary>
    public class UpdateSubjectCommandHandler : IRequestHandler<UpdateSubjectCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateSubjectCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<string> Handle(UpdateSubjectCommand request, CancellationToken cancellationToken)
        {
            var subjectDB = await _unitOfWork.SubjectRepository.GetByIdAsync(request.updateSubjectDTO.Id);
            if (subjectDB is null)
            {
                throw new NotFoundException($"The subject with id {request.updateSubjectDTO.Id} does not exist.");
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
