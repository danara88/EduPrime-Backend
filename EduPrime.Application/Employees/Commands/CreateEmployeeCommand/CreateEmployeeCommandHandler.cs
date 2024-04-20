using ErrorOr;
using MediatR;
using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Entities;
using EduPrime.Core.Employees;
using EduPrime.Core.Professors;
using EduPrime.Core.Exceptions;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Create employee command handler
    /// </summary>
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, ErrorOr<EmployeeDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IEmployeeRepositoryService _employeeRepositoryService;

        public CreateEmployeeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IEmployeeRepositoryService employeeRepositoryService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _employeeRepositoryService = employeeRepositoryService;
        }

        public async Task<ErrorOr<EmployeeDTO>> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            // Delete duplicated areas IDs
            request.createEmployeeDTO.Areas = request.createEmployeeDTO.Areas?.Distinct().ToList();
            var employee = _mapper.Map<Employee>(request.createEmployeeDTO);

            try
            {
                if (employee.Areas.Count == 0)
                {
                    // Throw error if the employee is assigned to a professor since it hasn't been added to any area
                    if (employee.Professor is not null)
                    {
                        return EmployeeErrors.EmployeeIsNotAssignedToProfessorArea;
                    }

                    await _unitOfWork.EmployeeRepository.AddAsync(employee);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    // If the employee that you are creating is assigned to a professor resource
                    if (employee.Professor is not null)
                    {
                        var areas = await _unitOfWork.AreaRepository.GetAllAsync();
                        // TODO: Delete "professor" hardcoded value
                        var professorArea = areas.FirstOrDefault(area => area.Name.ToLower().Contains("professor"));

                        // Throw error if the employee were not assigned to a Professor area
                        // and user is trying to create an employee with a professor resource
                        if (professorArea is not null && !employee.Areas.Any(a => a.Id == professorArea.Id))
                        {
                            return EmployeeErrors.EmployeeIsAssignedToProfessorResourceButNotAssignedToProfessorArea;
                        }

                        if (professorArea is null)
                        {
                            return ProfessorErrors.ProfessorAreaDoesNotExist;
                        }
                    }

                    await _employeeRepositoryService.AddEmployeeWithAreasToDB(employee);
                }

                var employeeDTO = _mapper.Map<EmployeeDTO>(employee);

                return employeeDTO;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while creating the resource.");
            }
        }
    }
}
