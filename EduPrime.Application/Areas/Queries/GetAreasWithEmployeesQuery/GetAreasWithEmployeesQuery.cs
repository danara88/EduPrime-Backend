﻿using EduPrime.Application.Common.Attributes;
using EduPrime.Core.DTOs.Area;
using EduPrime.Core.Permissions.Consts;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Areas.Queries
{
    /// <summary>
    /// Get areas with employees query
    /// </summary>
    [Authorize(Permissions = PermissionsConsts.GetAreasPermission)]
    public record GetAreasWithEmployeesQuery() : IRequest<ErrorOr<List<AreaWithEmployeesDTO>>> { }
}
