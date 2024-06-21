using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Delete employee command
    /// </summary>
    [Authorize(Permissions = PermissionsConsts.DeleteEmployeesPermission)]
    public record DeleteEmployeeCommand(int id) : IRequest<ErrorOr<string>> { }
}
