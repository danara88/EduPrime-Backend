using Microsoft.Extensions.Options;
using System.Security.Cryptography;
using System.Text;

namespace EduPrime.Application.Helpers.Security
{
    /// <summary>
    /// Security helper implementation
    /// </summary>
    public class SecurityHelper : ISecurityHelper
    {
        private readonly SecuritySettings _securitySettings;

        public SecurityHelper(IOptions<SecuritySettings> securitySettings)
        {
            _securitySettings = securitySettings.Value;
        }

        /// <summary>
        /// Method to encrypt a string
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string EncryptString(string inputText)
        {
            // Initialization vector of 16 bytes. It add an extra layer of randomness
            // to the encryption process.
            byte[] iv = new byte[16]; // Block size is 128 bits or 16 bytes.
            byte[] array;

            // AES (Advancde Encryption Standard) algorithm creation.
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(_securitySettings.KeyEncrypt);
                aes.IV = iv;

                // PKC27 Public Key Cryptography Standards #7
                // Appending bytes to the data to make it a multiple of the block size
                aes.Padding = PaddingMode.PKCS7;

                // CBC Cipher Block Chaining
                // This introduces dependency between blocks making it more secure
                // CBC provides confidentiality because each block of plaintext is dependent
                // on the previous block and the IV.
                aes.Mode = CipherMode.CBC;

                // Object in charge of making the encryption
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using MemoryStream memoryStream = new();
                using CryptoStream cryptoStream = new(memoryStream, encryptor, CryptoStreamMode.Write);
                using (StreamWriter streamWriter = new(cryptoStream))
                {
                    streamWriter.Write(inputText);
                }

                array = memoryStream.ToArray();
            }

            return Convert.ToBase64String(array);
        }
    }
}
