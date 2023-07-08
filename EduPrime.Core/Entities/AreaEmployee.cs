namespace EduPrime.Core.Entities
{
    /// <summary>
    /// AreaEmployee Entity
    /// </summary>
    public class AreaEmployee
    {
        public int AreaId { get; set; }

        public int EmployeeId { get; set; }

        public Area Area { get; set; }

        public Employee Employee { get; set; }
    }
}
