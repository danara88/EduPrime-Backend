using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Employee;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Upload RFC document command
    /// </summary>
    /// <param name="uploadEmployeeFileDTO"></param>
    public record UploadRFCDocumentCommand(UploadEmployeeFileDTO uploadEmployeeFileDTO) : IRequest<ErrorOr<EmployeeDTO>> { }
}
