using EduPrime.Core.Enums;

namespace EduPrime.Core.Entities
{
    /// <summary>
    /// Subject Entity
    /// </summary>
    public class Subject : BaseEntity
    {
        public string Name { get; set; }

        public SemesterTypeEnum AvailableSemester { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public List<ProfessorSubject> ProfessorsSubjects { get; set; }

        public List<StudentSubject> StudentsSubjects { get; set; }
    }
}
