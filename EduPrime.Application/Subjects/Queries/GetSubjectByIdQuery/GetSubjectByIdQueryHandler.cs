using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Subject;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Subjects.Queries
{
    /// <summary>
    /// Get subject by id query handler
    /// </summary>
    public class GetSubjectByIdQueryHandler : IRequestHandler<GetSubjectByIdQuery, SubjectDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetSubjectByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<SubjectDTO> Handle(GetSubjectByIdQuery request, CancellationToken cancellationToken)
        {
            var subject = await _unitOfWork.SubjectRepository.GetSubjectWithProfessorsAsync(request.id);
            if (subject is null)
            {
                throw new NotFoundException($"The subject with id {request.id} does not exist.");
            }

            var subjectDTO = _mapper.Map<SubjectDTO>(subject);

            return subjectDTO;
        }
    }
}
