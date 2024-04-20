using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Employee;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Upload employee picture command
    /// </summary>
    /// <param name="uploadEmployeeFileDTO"></param>
    public record UploadEmployeePictureCommand(UploadEmployeeFileDTO uploadEmployeeFileDTO) : IRequest<ErrorOr<EmployeeDTO>> { }
}
