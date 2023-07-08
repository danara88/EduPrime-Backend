namespace EduPrime.Core.Entities
{
    /// <summary>
    /// Professor Entity
    /// </summary>
    public class Professor : BaseEntity
    {
        public int EmployeeId { get; set; }

        public int Satisfaction { get; set; }

        public int YearsOnDuty { get; set; }

        public List<ProfessorSubject> ProfessorsSubjects { get; set; }
    }
}
