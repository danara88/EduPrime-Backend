using AutoMapper;
using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Professor;
using EduPrime.Core.Professors;

namespace EduPrime.Application.Professors.Queries
{
    /// <summary>
    /// Get professor by id query handler
    /// </summary>
    public class GetProfessorByIdQueryHandler : IRequestHandler<GetProfessorByIdQuery, ErrorOr<ProfessorDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetProfessorByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<ProfessorDTO>> Handle(GetProfessorByIdQuery request, CancellationToken cancellationToken)
        {
            var professor = await _unitOfWork.ProfessorRepository.GetProfessorWithEmployeeAsync(request.id);
            if (professor is null)
            {
                return ProfessorErrors.ProfessorWithIdDoesNotExist(request.id);
            }

            var professorDTO = _mapper.Map<ProfessorDTO>(professor);

            return professorDTO;
        }
    }
}
