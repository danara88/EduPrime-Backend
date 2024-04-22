using ErrorOr;

namespace EduPrime.Core.Users;

/// <summary>
/// User domain errors
/// </summary>
public static class UserErrors
{
    public static readonly Error InvalidPasswordFormat =
        Error.Validation(
            "User.InvalidPasswordFormat",
            "Invalid password format."
        );

    public static readonly Error InvalidUserCredentials =
        Error.Validation(
            "User.InvalidUserCredentials",
            "Invalid user credentials."
        );

    public static readonly Error UserEmailDoesNotExist =
        Error.Validation(
            "User.UserEmailDoesNotExist",
            "User email does not exist."
        );

    public static readonly Error InvalidVerificationToken =
        Error.Validation(
            "User.InvalidVerificationToken",
            "The verification token is invalid."
        );

    public static readonly Error ExpiredVerificationToken =
        Error.Validation(
            "User.ExpiredVerificationToken",
            "The verification token has expired."
        );

    public static readonly Error UserEmailAlreadyConfirmed =
        Error.Validation(
            "User.UserEmailAlreadyConfirmed",
            "The email is already confirmed."
        );

    public static readonly Error UserEmailMustBeConfirmed =
        Error.Validation(
            "User.UserEmailMustBeConfirmed",
            "The email must be confirmed."
        );

    public static Error UserWithIdDoesNotExist(int id)
    {
        return Error.NotFound(
            "User.UserWithIdDoesNotExist",
            $"The user with id {id} does not exist.");
    }

    public static Error UserEmailAlreadyRegistered(string email)
    {
        return Error.Conflict(
            "User.UserEmailAlreadyRegistered",
            $"The email {email} is already registered.");
    }
}
