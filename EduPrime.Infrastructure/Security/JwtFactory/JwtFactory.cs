using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Permission;
using EduPrime.Core.DTOs.User;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EduPrime.Infrastructure.Security
{
    /// <summary>
    /// JWT Factory implementation
    /// </summary>
    public class JwtFactory : IJwtFactory
    {
        private readonly JwtSettings _jwtSettings;

        public JwtFactory(IOptions<JwtSettings> jwtSettings)
        {
            _jwtSettings = jwtSettings.Value;
        }

        /// <summary>
        /// Method to generate the JWT token
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public string GenerateJwtToken(UserDTO userDTO)
        {
            JwtSecurityTokenHandler jwtTokenHandler = new ();
            byte[] secretKey = Encoding.UTF8.GetBytes(_jwtSettings.Secret);

            List<Claim> claims = new()
            {
                new Claim("id", userDTO.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, userDTO.Email),
                new Claim(JwtRegisteredClaimNames.Name, userDTO.Name),
                new Claim("surname", userDTO.Surname),
                new Claim("role", userDTO.Role.Name),

                // Include Iat (Issued at) identify the date and time when this token was emitted.
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),

                // Include Jti (token ID) to avoid client re-use the token again.
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            AddPermissions(claims, userDTO.Role.Permissions);

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(_jwtSettings.ValidTimeMinutes),
                Issuer = _jwtSettings.Issuer,
                Audience = _jwtSettings.Audience,

                // Verified that the secret key is issued by the ORIGINAL source.
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha256)
            };

            SecurityToken token = jwtTokenHandler.CreateToken(tokenDescriptor);

            return jwtTokenHandler.WriteToken(token);
        }

        private void AddPermissions(List<Claim> claims, List<PermissionDTO> permissions)
        {
            permissions.ForEach(permission => {
                claims.AddIfValueNotNull("permissions", permission.Name);
            });
        }
    }
}
