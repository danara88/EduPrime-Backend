﻿using ErrorOr;
using MediatR;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Permissions.Consts;
using EduPrime.Application.Common.Attributes;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Upload RFC document command
    /// </summary>
    /// <param name="uploadEmployeeFileDTO"></param>
    [Authorize(Permissions = PermissionsConsts.UpdateEmployeesPermission)]
    public record UploadRFCDocumentCommand(UploadEmployeeFileDTO uploadEmployeeFileDTO) : IRequest<ErrorOr<EmployeeDTO>> { }
}
