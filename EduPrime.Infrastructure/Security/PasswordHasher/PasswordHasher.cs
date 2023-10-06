using Microsoft.Extensions.Options;
using System.Security.Cryptography;

namespace EduPrime.Infrastructure.Security
{
    /// <summary>
    /// Password service implementation
    /// </summary>
    public class PasswordHasher : IPasswordHasher
    {
        private readonly PasswordSettings _passwordSettings;

        private static readonly HashAlgorithmName _hashAlgorithmName = HashAlgorithmName.SHA256;
        private const char Delimiter = ';';

        public PasswordHasher(IOptions<PasswordSettings> passwordSettings)
        {
            _passwordSettings = passwordSettings.Value;
        }

        /// <summary>
        /// Method to check if the hashed pasword is equal to the password
        /// </summary>
        /// <param name="passwordHash"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Check(string passwordHash, string password)
        {
            var elements = passwordHash.Split(Delimiter);
            var salt = Convert.FromBase64String(elements[0]);
            var hash = Convert.FromBase64String(elements[1]);

            var hashInput = Rfc2898DeriveBytes.Pbkdf2(password, salt, _passwordSettings.Iterations, _hashAlgorithmName, _passwordSettings.KeySize);

            return CryptographicOperations.FixedTimeEquals(hash, hashInput);
        }

        /// <summary>
        /// Method to generate hash value from a string
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string Hash(string password)
        {
            var salt = RandomNumberGenerator.GetBytes(_passwordSettings.SaltSize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, _passwordSettings.Iterations, _hashAlgorithmName, _passwordSettings.KeySize);
            return string.Join(Delimiter, Convert.ToBase64String(salt), Convert.ToBase64String(hash));
        }
    }
}
