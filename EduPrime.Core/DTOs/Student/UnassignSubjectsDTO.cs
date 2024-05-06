using EduPrime.Core.Enums.Student;

namespace EduPrime.Core.DTOs.Student
{
    public class UnassignSubjectsDTO
    {
        public int StudentId { get; set; }

        public UnassignSubjectsActionEnum UnassignAction { get; set; } = UnassignSubjectsActionEnum.NotAll;

        public List<int> SubjectIds { get; set; }
    }
}
