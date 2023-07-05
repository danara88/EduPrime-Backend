namespace EduPrime.Core.Entities
{
    /// <summary>
    /// User Entity
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime? LastLogin { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public Role Role { get; set; }
    }
}
