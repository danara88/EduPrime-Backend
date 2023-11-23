namespace EduPrime.Application.Common.Interfaces
{
    /// <summary>
    /// Password service interface
    /// </summary>
    public interface IPasswordHasher
    {
        string Hash(string password);

        bool Check(string passwordHash, string password);
    }
}
