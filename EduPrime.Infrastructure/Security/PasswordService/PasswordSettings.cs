namespace EduPrime.Infrastructure.Security
{
    /// <summary>
    /// Password settings
    /// </summary>
    public class PasswordSettings
    {
        public int SaltSize { get; set; }

        public int KeySize { get; set; }

        public int Iterations { get; set; }
    }
}
