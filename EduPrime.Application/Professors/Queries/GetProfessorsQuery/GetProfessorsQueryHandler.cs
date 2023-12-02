using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Professor;
using MediatR;

namespace EduPrime.Application.Professors.Queries
{
    /// <summary>
    /// Get professors query handler
    /// </summary>
    public class GetProfessorsQueryHandler : IRequestHandler<GetProfessorsQuery, List<ProfessorDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetProfessorsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ProfessorDTO>> Handle(GetProfessorsQuery request, CancellationToken cancellationToken)
        {
            var professors = await _unitOfWork.ProfessorRepository.GetProfessorsWithEmployeeAsync();
            var professorsDTO = _mapper.Map<List<ProfessorDTO>>(professors);

            return professorsDTO;
        }
    }
}
