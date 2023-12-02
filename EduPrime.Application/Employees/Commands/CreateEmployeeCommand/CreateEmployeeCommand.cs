using EduPrime.Core.DTOs.Employee;
using MediatR;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Create employee command
    /// </summary>
    /// <param name="createEmployeeDTO"></param>
    public record CreateEmployeeCommand(CreateEmployeeDTO createEmployeeDTO) : IRequest<EmployeeDTO> { }
}
