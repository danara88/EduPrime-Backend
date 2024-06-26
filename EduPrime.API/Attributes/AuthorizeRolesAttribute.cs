﻿using Microsoft.AspNetCore.Authorization;

namespace EduPrime.Api.Attributes
{
    /// <summary>
    /// Deprecated: Authorize roles custom attribute
    /// </summary>
    public class AuthorizeRolesAttribute : AuthorizeAttribute
    {
        public AuthorizeRolesAttribute(params string[] roles)
        {
            Roles = string.Join(",", roles);
        }
    }
}
