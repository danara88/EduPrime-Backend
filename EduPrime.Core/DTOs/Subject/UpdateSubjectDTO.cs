using EduPrime.Core.Enums;

namespace EduPrime.Core.DTOs.Subject
{
    public class UpdateSubjectDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public SemesterTypeEnum AvailableSemester { get; set; }
    }
}
