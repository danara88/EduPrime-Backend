using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Create employee command
    /// </summary>
    /// <param name="createEmployeeDTO"></param>
    [Authorize(Permissions = PermissionsConsts.CreateEmployeesPermission)]
    public record CreateEmployeeCommand(CreateEmployeeDTO createEmployeeDTO) : IRequest<ErrorOr<EmployeeDTO>> { }
}
