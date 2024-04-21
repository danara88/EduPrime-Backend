using AutoMapper;
using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Subject;
using EduPrime.Core.Subjects;

namespace EduPrime.Application.Subjects.Queries
{
    /// <summary>
    /// Get subject by id query handler
    /// </summary>
    public class GetSubjectByIdQueryHandler : IRequestHandler<GetSubjectByIdQuery, ErrorOr<SubjectDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetSubjectByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<SubjectDTO>> Handle(GetSubjectByIdQuery request, CancellationToken cancellationToken)
        {
            var subject = await _unitOfWork.SubjectRepository.GetSubjectWithProfessorsAsync(request.id);
            if (subject is null)
            {
                return SubjectErrors.SubjectWithIdDoesNotExist(request.id);
            }

            var subjectDTO = _mapper.Map<SubjectDTO>(subject);

            return subjectDTO;
        }
    }
}
