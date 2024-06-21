using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Download RFC document command
    /// </summary>
    /// <param name="employeeId"></param>
    [Authorize(Permissions = PermissionsConsts.GetEmployeesPermission)]
    public record DownloadRFCDocumentCommand(int employeeId) : IRequest<ErrorOr<DownloadEmployeeRfcDTO>> { }
}
