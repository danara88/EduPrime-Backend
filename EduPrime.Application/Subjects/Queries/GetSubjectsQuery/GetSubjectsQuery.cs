using EduPrime.Application.Common.Attributes;
using EduPrime.Core.DTOs.Shared;
using EduPrime.Core.DTOs.Subject;
using EduPrime.Core.Permissions.Consts;
using MediatR;

namespace EduPrime.Application.Subjects.Queries
{
    /// <summary>
    /// Get subjects query
    /// </summary>
    /// <param name="paginationDTO"></param>
    [Authorize(Permissions = PermissionsConsts.GetSubjectsPermission)]
    public record GetSubjectsQuery(PaginationDTO paginationDTO) : IRequest<List<SubjectDTO>> { }
}
