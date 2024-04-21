using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Student;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Upload student picture command
    /// </summary>
    /// <param name="uploadStudentFileDTO"></param>
    public record UploadStudentPictureCommand(UploadStudentFileDTO uploadStudentFileDTO) : IRequest<ErrorOr<StudentDTO>> { }
}
