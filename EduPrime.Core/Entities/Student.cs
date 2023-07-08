using EduPrime.Core.Enums;

namespace EduPrime.Core.Entities
{
    /// <summary>
    /// Student Entity
    /// </summary>
    public class Student : BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? Picture { get; set; }

        public string? PhoneNumber { get; set; }

        public string EmergencyContact { get; set; }

        public SemesterTypeEnum CurrentSemester { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public List<StudentSubject> StudentsSubjects { get; set; }
    }
}
