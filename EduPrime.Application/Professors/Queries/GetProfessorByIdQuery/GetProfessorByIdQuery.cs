using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Professor;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Professors.Queries
{
    /// <summary>
    /// Get professor by id
    /// </summary>
    /// <param name="id"></param>
    [Authorize(Permissions = PermissionsConsts.GetProfessorsPermission)]
    public record GetProfessorByIdQuery(int id) : IRequest<ErrorOr<ProfessorDTO>> { }
}
