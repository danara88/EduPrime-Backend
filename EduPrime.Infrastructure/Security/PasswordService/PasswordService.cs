using EduPrime.Application.Common.Interfaces;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace EduPrime.Infrastructure.Security
{
    /// <summary>
    /// Password service implementation
    /// </summary>
    public class PasswordService : IPasswordService
    {
        private readonly PasswordSettings _passwordSettings;

        private static readonly HashAlgorithmName _hashAlgorithmName = HashAlgorithmName.SHA256;
        private const char Delimiter = ';';

        public PasswordService(IOptions<PasswordSettings> passwordSettings)
        {
            _passwordSettings = passwordSettings.Value;
        }

        /// <summary>
        /// Method to check if the hashed pasword is equal to the password
        /// </summary>
        /// <param name="passwordHash"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckHash(string passwordHash, string password)
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
        public string HashPassword(string password)
        {
            var salt = RandomNumberGenerator.GetBytes(_passwordSettings.SaltSize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, _passwordSettings.Iterations, _hashAlgorithmName, _passwordSettings.KeySize);
            return string.Join(Delimiter, Convert.ToBase64String(salt), Convert.ToBase64String(hash));
        }

        /// <summary>
        /// Validates the password format
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsValidPassword(string password)
        {
            bool validPassword = true;

            // Password must has at least 7 characters
            if (password.Length < 7) validPassword = false;

            // Password must contains at leat one uppercase letter
            if (!Regex.IsMatch(password, "[A-Z]")) validPassword = false;

            // Password must contains both letters and numbers
            if (!Regex.IsMatch(password, "[a-zA-Z]") || !Regex.IsMatch(password, "[0-9]")) validPassword = false;

            return validPassword;
        }
    }
}
