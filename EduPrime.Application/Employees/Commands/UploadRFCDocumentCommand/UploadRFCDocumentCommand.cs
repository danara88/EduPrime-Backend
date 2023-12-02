using EduPrime.Core.DTOs.Employee;
using MediatR;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Upload RFC document command
    /// </summary>
    /// <param name="uploadEmployeeFileDTO"></param>
    public record UploadRFCDocumentCommand(UploadEmployeeFileDTO uploadEmployeeFileDTO) : IRequest<EmployeeDTO> { }
}
