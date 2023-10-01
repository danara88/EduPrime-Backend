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

        public string? PictureURL { get; set; }

        public string? RfcDocument { get; set; }

        public Professor Professor { get; set; }

        public List<Area> Areas { get; set; }
    }
}
