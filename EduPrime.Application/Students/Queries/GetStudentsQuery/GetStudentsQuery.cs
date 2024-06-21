using EduPrime.Application.Common.Attributes;
using EduPrime.Core.DTOs.Shared;
using EduPrime.Core.DTOs.Student;
using EduPrime.Core.Permissions.Consts;
using MediatR;

namespace EduPrime.Application.Students.Queries
{
    /// <summary>
    /// Get students query
    /// </summary>
    /// <param name="paginationDTO"></param>
    [Authorize(Permissions = PermissionsConsts.GetStudentsPermission)]
    public record GetStudentsQuery(PaginationDTO paginationDTO) : IRequest<List<StudentDTO>> { }
}
