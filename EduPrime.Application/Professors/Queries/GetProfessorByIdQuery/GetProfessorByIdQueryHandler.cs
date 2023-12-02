using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Professor;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Professors.Queries
{
    /// <summary>
    /// Get professor by id query handler
    /// </summary>
    public class GetProfessorByIdQueryHandler : IRequestHandler<GetProfessorByIdQuery, ProfessorDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetProfessorByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ProfessorDTO> Handle(GetProfessorByIdQuery request, CancellationToken cancellationToken)
        {
            var professor = await _unitOfWork.ProfessorRepository.GetProfessorWithEmployeeAsync(request.id);
            if (professor is null)
            {
                throw new NotFoundException($"The professor with id {request.id} does not exist.");
            }

            var professorDTO = _mapper.Map<ProfessorDTO>(professor);

            return professorDTO;
        }
    }
}
