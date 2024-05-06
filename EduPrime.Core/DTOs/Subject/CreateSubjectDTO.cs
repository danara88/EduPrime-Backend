using EduPrime.Core.Enums;

namespace EduPrime.Core.DTOs.Subject
{
    public class CreateSubjectDTO
    {
        public string Name { get; set; }

        public SemesterTypeEnum AvailableSemester { get; set; }

        public List<int> ProfessorIds { get; set; }
    }
}
