using EduPrime.Core.DTOs.Student;
using MediatR;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Upload student picture command
    /// </summary>
    /// <param name="uploadStudentFileDTO"></param>
    public record UploadStudentPictureCommand(UploadStudentFileDTO uploadStudentFileDTO) : IRequest<StudentDTO> { }
}
