using MediatR;
using ErrorOr;
using EduPrime.Core.DTOs.Professor;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Professors.Commands
{
    /// <summary>
    /// Create professor command
    /// </summary>
    /// <param name="createProfessorDTO"></param>
    [Authorize(Permissions = PermissionsConsts.CreateProfessorsPermission)]
    public record CreateProfessorCommand(CreateProfessorDTO createProfessorDTO) : IRequest<ErrorOr<ProfessorDTO>> { }
}
