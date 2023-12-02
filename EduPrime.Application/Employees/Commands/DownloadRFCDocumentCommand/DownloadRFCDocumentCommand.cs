using EduPrime.Core.DTOs.Employee;
using MediatR;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Download RFC document command
    /// </summary>
    /// <param name="employeeId"></param>
    public record DownloadRFCDocumentCommand(int employeeId) : IRequest<DownloadEmployeeRfcDTO> { }
}
