namespace EduPrime.Core.Entities
{
    /// <summary>
    /// Area Entity
    /// </summary>
    public class Area : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn  { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public List<AreaEmployee> AreasEmployees { get; set; }
    }
}
