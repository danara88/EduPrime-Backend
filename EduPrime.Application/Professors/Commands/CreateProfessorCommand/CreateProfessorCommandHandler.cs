using AutoMapper;
using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Professor;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Professors;
using EduPrime.Core.Employees;

namespace EduPrime.Application.Professors.Commands
{
    /// <summary>
    /// Create professor command handler
    /// </summary>
    public class CreateProfessorCommandHandler : IRequestHandler<CreateProfessorCommand, ErrorOr<ProfessorDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateProfessorCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<ProfessorDTO>> Handle(CreateProfessorCommand request, CancellationToken cancellationToken)
        {
            if (!await _unitOfWork.EmployeeRepository.ExistsAnyEmployee(request.createProfessorDTO.EmployeeId))
            {
                return EmployeeErrors.EmployeeWithIdDoesNotExist(request.createProfessorDTO.EmployeeId);
            }

            var employee = await _unitOfWork.EmployeeRepository.GetEmployeeAsync(request.createProfessorDTO.EmployeeId);

            var areas = await _unitOfWork.AreaRepository.GetAllAsync();

            // TODO: Delete "professor" hardcoded value
            var professorArea = areas.FirstOrDefault(area => area.Name.ToLower().Contains("professor"));

            if (professorArea is not null && (!employee.Areas.Any(a => a.Id == professorArea.Id)))
            {
                return ProfessorErrors.EmployeeIsNotAssignedToProfessorArea;
            }

            if (professorArea is null)
            {
                return ProfessorErrors.ProfessorAreaDoesNotExist;
            }

            var professor = _mapper.Map<Professor>(request.createProfessorDTO);

            try
            {
                await _unitOfWork.ProfessorRepository.AddAsync(professor);
                await _unitOfWork.SaveChangesAsync();
                var professorDTO = _mapper.Map<ProfessorDTO>(professor);

                return professorDTO;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while creating the resource.");
            }
        }
    }
}
