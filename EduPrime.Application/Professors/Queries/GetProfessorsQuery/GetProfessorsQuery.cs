using MediatR;
using EduPrime.Core.DTOs.Professor;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Professors.Queries
{
    /// <summary>
    /// Get professors query
    /// </summary>
    [Authorize(Permissions = PermissionsConsts.GetProfessorsPermission)]
    public record GetProfessorsQuery() : IRequest<List<ProfessorDTO>> { }
}
