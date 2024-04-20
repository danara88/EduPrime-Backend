using ErrorOr;

namespace EduPrime.Core.Common;

/// <summary>
/// Common domain errors
/// </summary>
public static class CommonErrors
{
    public static readonly Error FileOrDocumentNotFound =
            Error.Validation(
                "Common.FileOrDocumentNotFound",
                "File not found. A file must be attached.");

    public static Error InvalidFileExtension(string[] allowedExtensions = null)
    {
        if (allowedExtensions == null)
        {
            allowedExtensions = new string[] {"png", "jpg"};
        }

        return Error.Validation(
            "Common.InvalidFileExtension",
            $"Invalid file extension. Allowed file extensions: {string.Join(", ", allowedExtensions)}.");
    }
}
