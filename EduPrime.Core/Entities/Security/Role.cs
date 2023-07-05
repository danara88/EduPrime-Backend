namespace EduPrime.Core.Entities
{
    /// <summary>
    /// Role Entity
    /// </summary>
    public class Role
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }
    }
}
