using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Employee;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Download RFC document command
    /// </summary>
    /// <param name="employeeId"></param>
    public record DownloadRFCDocumentCommand(int employeeId) : IRequest<ErrorOr<DownloadEmployeeRfcDTO>> { }
}
