using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using EduPrime.Application.Users.Interfaces;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Users;

namespace EduPrime.Api.Services;

/// <summary>
/// Current user provider implementation
/// </summary>
public class CurrentUserProvider : ICurrentUserProvider
{
    private readonly IHttpContextAccessor _httpContextAccesor;

    public CurrentUserProvider(IHttpContextAccessor httpContextAccesor)
    {
        _httpContextAccesor = httpContextAccesor;
    }

    public CurrentUser GetCurrentUser()
    {
        if (_httpContextAccesor.HttpContext is null)
        {
            throw new InternalServerException("Something went wrong.");
        }

        var id = GetClaimValues("id")
            .Select(value => int.Parse(value))
            .First();

        var permissions = GetClaimValues("permissions");

        var roles = GetClaimValues(ClaimTypes.Role);

        return new CurrentUser(
            Id: id,
            Permissions: permissions,
            Roles: roles
        );
    }

    private IReadOnlyList<string> GetClaimValues(string claimType)
    {
        return _httpContextAccesor.HttpContext!.User.Claims
            .Where(claim => claim.Type == claimType)
            .Select(claim => claim.Value)
            .ToList();
    }
}
