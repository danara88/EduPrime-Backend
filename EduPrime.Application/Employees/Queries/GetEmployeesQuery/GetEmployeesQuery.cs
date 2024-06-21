using EduPrime.Application.Common.Attributes;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Permissions.Consts;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Employees.Queries
{
    /// <summary>
    /// Get employee query
    /// </summary>
    [Authorize(Permissions = PermissionsConsts.GetEmployeesPermission)]
    public record GetEmployeesQuery() : IRequest<ErrorOr<List<EmployeeDTO>>> { }
}
