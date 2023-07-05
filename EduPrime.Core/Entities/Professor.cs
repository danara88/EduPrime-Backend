namespace EduPrime.Core.Entities
{
    /// <summary>
    /// Professor Entity
    /// </summary>
    public class Professor
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int Satisfaction { get; set; }

        public int YearsOnDuty { get; set; }

        public List<ProfessorSubject> ProfessorsSubjects { get; set; }
    }
}
