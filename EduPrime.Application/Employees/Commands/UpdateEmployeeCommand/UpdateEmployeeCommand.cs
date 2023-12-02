using EduPrime.Core.DTOs.Employee;
using MediatR;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Update employee command
    /// </summary>
    /// <param name="updateEmployeeDTO"></param>
    public record UpdateEmployeeCommand(UpdateEmployeeDTO updateEmployeeDTO) : IRequest<EmployeeDTO> { }
}
