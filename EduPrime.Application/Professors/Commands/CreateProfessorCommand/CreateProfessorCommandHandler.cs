using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Professor;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Professors.Commands
{
    /// <summary>
    /// Create professor command handler
    /// </summary>
    public class CreateProfessorCommandHandler : IRequestHandler<CreateProfessorCommand, ProfessorDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateProfessorCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ProfessorDTO> Handle(CreateProfessorCommand request, CancellationToken cancellationToken)
        {
            if (!(await _unitOfWork.EmployeeRepository.ExistsAnyEmployee(request.createProfessorDTO.EmployeeId)))
            {
                throw new NotFoundException($"The employee with id {request.createProfessorDTO.EmployeeId} does not exist.");
            }

            var employee = await _unitOfWork.EmployeeRepository.GetEmployeeAsync(request.createProfessorDTO.EmployeeId);

            var areas = await _unitOfWork.AreaRepository.GetAllAsync();
            var professorArea = areas.FirstOrDefault(area => area.Name.ToLower().Contains("professor"));

            if (professorArea is not null)
            {
                if (!employee.Areas.Any(a => a.Id == professorArea.Id))
                {
                    throw new BadRequestException($"The employee {employee.Name} {employee.Surname} is not assigned to a professor area.");
                }
            }
            else
            {
                throw new BadRequestException("There is not area for professor.");
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
