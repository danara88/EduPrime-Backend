using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Subject;
using MediatR;

namespace EduPrime.Application.Subjects.Queries
{
    /// <summary>
    /// Get subjects query handler
    /// </summary>
    public class GetSubjectsQueryHandler : IRequestHandler<GetSubjectsQuery, List<SubjectDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetSubjectsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<SubjectDTO>> Handle(GetSubjectsQuery request, CancellationToken cancellationToken)
        {
            var subjects = (await _unitOfWork.SubjectRepository.GetSubjectsWithProfessorsAsync())
            .Skip((request.paginationDTO.CurrentPage - 1) * request.paginationDTO.QuantityPerPage)
            .Take(request.paginationDTO.QuantityPerPage)
                .ToList();

            var subjectsDTO = _mapper.Map<List<SubjectDTO>>(subjects);

            return subjectsDTO;
        }
    }
}
