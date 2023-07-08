namespace EduPrime.Core.Entities
{
    /// <summary>
    /// Employee Entity
    /// </summary>
    public class Employee : BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string? Picture { get; set; }

        public string? RfcDocument { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public Professor Professor { get; set; }

        public List<AreaEmployee> AreasEmployees { get; set; }
    }
}
