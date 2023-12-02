using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Create employee command handler
    /// </summary>
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, EmployeeDTO>
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

        public async Task<EmployeeDTO> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            request.createEmployeeDTO.Areas = request.createEmployeeDTO.Areas?.Distinct().ToList();
            var employee = _mapper.Map<Employee>(request.createEmployeeDTO);

            try
            {
                if (employee.Areas.Count == 0)
                {
                    if (employee.Professor is not null)
                    {
                        throw new Exception();
                    }

                    await _unitOfWork.EmployeeRepository.AddAsync(employee);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    if (employee.Professor is not null)
                    {
                        var areas = await _unitOfWork.AreaRepository.GetAllAsync();
                        var professorArea = areas.FirstOrDefault(area => area.Name.ToLower().Contains("professor"));
                        if (professorArea is not null)
                        {
                            if (!employee.Areas.Any(a => a.Id == professorArea.Id))
                            {
                                throw new Exception();
                            }
                        }
                        else
                        {
                            throw new Exception();
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
