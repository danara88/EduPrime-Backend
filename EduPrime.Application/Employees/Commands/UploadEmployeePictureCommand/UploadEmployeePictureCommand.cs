using EduPrime.Core.DTOs.Employee;
using MediatR;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Upload employee picture command
    /// </summary>
    /// <param name="uploadEmployeeFileDTO"></param>
    public record UploadEmployeePictureCommand(UploadEmployeeFileDTO uploadEmployeeFileDTO) : IRequest<EmployeeDTO> { }
}
