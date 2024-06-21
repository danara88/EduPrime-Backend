using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Permissions.Consts;
using EduPrime.Application.Common.Attributes;

namespace EduPrime.Application.Employees.Queries
{
    /// <summary>
    /// Get employee by id query
    /// </summary>
    /// <param name="id"></param>
    [Authorize(Permissions = PermissionsConsts.GetEmployeesPermission)]
    public record GetEmployeeByIdQuery(int id) : IRequest<ErrorOr<EmployeeDTO>> { }
}
