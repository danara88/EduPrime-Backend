using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Professor;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Professors.Commands
{
    /// <summary>
    /// Update professor command
    /// </summary>
    /// <param name="updateProfessorDTO"></param>
    [Authorize(Permissions = PermissionsConsts.UpdateProfessorsPermission)]
    public record UpdateProfessorCommand(UpdateProfessorDTO updateProfessorDTO) : IRequest<ErrorOr<ProfessorDTO>> { }
}
