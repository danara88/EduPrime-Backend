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
        public string ValidTimeMinutes { get; set; }
    }
}
