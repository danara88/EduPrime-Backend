using System.Reflection;
using ErrorOr;
using MediatR;
using EduPrime.Application.Users.Interfaces;
using EduPrime.Application.Common.Attributes;

namespace EduPrime.Application.Common.Behaviors;

/// <summary>
/// Generic authorization pipeline behavior
/// </summary>
/// <typeparam name="TRequest"></typeparam>
/// <typeparam name="TResponse"></typeparam>
public class AuthorizationBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
        where TResponse : IErrorOr
{
    private readonly ICurrentUserProvider _currentUserProvider;

    public AuthorizationBehavior(ICurrentUserProvider currentUserProvider)
    {
        _currentUserProvider = currentUserProvider;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        var authorizationAttributes = request.GetType()
            .GetCustomAttributes<AuthorizeAttribute>()
            .ToList();

        if (authorizationAttributes.Count == 0)
        {
            return await next();
        }

        List<string> requiredPermissions = authorizationAttributes
            .SelectMany(authorizationAttribute => authorizationAttribute.Permissions?.Split(',') ?? Enumerable.Empty<string>())
            .ToList();

        var currentUser = _currentUserProvider.GetCurrentUser();

        if (requiredPermissions.Except(currentUser.Permissions).Count() > 0)
        {
            return (dynamic)Error.Unauthorized(description: "User is forbidden from taking this action.");
        }

        /*
        * In current discussions to include role-based authorization
        */

        // List<string> requiredRoles = authorizationAttributes
        //     .SelectMany(authorizationAttribute => authorizationAttribute.Roles?.Split(',') ?? Enumerable.Empty<string>())
        //     .ToList();

        // if (requiredRoles.Except(currentUser.Roles).Count() > 0)
        // {
        //     return (dynamic)Error.Unauthorized(description: "User is forbidden from taking this action.");
        // }

        return await next();
    }
}
