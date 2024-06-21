using EduPrime.Core.Users;

namespace EduPrime.Application.Users.Interfaces;

/// <summary>
/// Current user provider interface
/// </summary>
public interface ICurrentUserProvider
{
    CurrentUser GetCurrentUser();
}
