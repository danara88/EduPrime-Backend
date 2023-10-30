namespace EduPrime.Infrastructure.Security
{
    /// <summary>
    /// Jwt settings
    /// </summary>
    public class JwtSettings
    {
        /// <summary>
        /// JWT secret key
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// JWT token valid time in minutes
        /// </summary>
        public int ValidTimeMinutes { get; set; }

        /// <summary>
        /// Source that emits the token
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Valid audience.
        /// Change this to the client's source
        /// </summary>
        public string Audience { get; set; }
    }
}
