namespace EduPrime.Core.Entities
{
    /// <summary>
    /// Area Entity
    /// </summary>
    public class Area : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
