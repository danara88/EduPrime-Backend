﻿using AutoMapper;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Professor;
using ErrorOr;

namespace EduPrime.Application.Professors.Queries
{
    /// <summary>
    /// Get professors query handler
    /// </summary>
    public class GetProfessorsQueryHandler : IRequestHandler<GetProfessorsQuery, ErrorOr<List<ProfessorDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetProfessorsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<List<ProfessorDTO>>> Handle(GetProfessorsQuery request, CancellationToken cancellationToken)
        {
            var professors = await _unitOfWork.ProfessorRepository.GetProfessorsWithEmployeeAsync();
            var professorsDTO = _mapper.Map<List<ProfessorDTO>>(professors);

            return professorsDTO;
        }
    }
}
