namespace EduPrime.Core.Entities
{
    /// <summary>
    /// Area Entity
    /// </summary>
    public class Area
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedOn  { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public List<AreaEmployee> AreasEmployees { get; set; }
    }
}
