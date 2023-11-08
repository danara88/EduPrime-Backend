namespace EduPrime.Core.Entities
{
    /// <summary>
    /// User Entity
    /// </summary>
    public class User : BaseEntity
    {
        public int RoleId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string VerificationToken { get; set; } = null;

        public DateTime? VerifiedAt { get; set; }

        public bool EmailConfirmed { get; set; } = false;

        public DateTime? LastLogin { get; set; }

        public Role Role { get; set; }
    }
}
