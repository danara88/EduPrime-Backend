using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Subject;
using EduPrime.Application.Common.Attributes;
using EduPrime.Core.Permissions.Consts;

namespace EduPrime.Application.Subjects.Queries
{
    /// <summary>
    /// Get subject by id query
    /// </summary>
    /// <param name="id"></param>
    [Authorize(Permissions = PermissionsConsts.GetSubjectsPermission)]
    public record GetSubjectByIdQuery(int id) : IRequest<ErrorOr<SubjectDTO>> { }
}
