namespace EduPrime.Application.Common.Interfaces
{
    /// <summary>
    /// Password service interface
    /// </summary>
    public interface IPasswordService
    {
        string HashPassword(string password);

        bool CheckHash(string passwordHash, string password);

        bool IsValidPassword(string password);
    }
}
