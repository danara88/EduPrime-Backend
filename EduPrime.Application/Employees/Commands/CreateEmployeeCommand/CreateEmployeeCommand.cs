using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Employee;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Create employee command
    /// </summary>
    /// <param name="createEmployeeDTO"></param>
    public record CreateEmployeeCommand(CreateEmployeeDTO createEmployeeDTO) : IRequest<ErrorOr<EmployeeDTO>> { }
}
