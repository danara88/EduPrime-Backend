using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Employee;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Update employee command
    /// </summary>
    /// <param name="updateEmployeeDTO"></param>
    public record UpdateEmployeeCommand(UpdateEmployeeDTO updateEmployeeDTO) : IRequest<ErrorOr<EmployeeDTO>> { }
}
