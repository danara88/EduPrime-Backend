namespace EduPrime.Core.Entities
{
    /// <summary>
    /// Role Entity
    /// </summary>
    public class Role : BaseEntity
    {
        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }
    }
}
