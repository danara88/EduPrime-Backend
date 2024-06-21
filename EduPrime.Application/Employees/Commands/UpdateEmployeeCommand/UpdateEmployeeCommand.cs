using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Permissions.Consts;
using EduPrime.Application.Common.Attributes;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Update employee command
    /// </summary>
    /// <param name="updateEmployeeDTO"></param>
    [Authorize(Permissions = PermissionsConsts.UpdateEmployeesPermission)]
    public record UpdateEmployeeCommand(UpdateEmployeeDTO updateEmployeeDTO) : IRequest<ErrorOr<EmployeeDTO>> { }
}
