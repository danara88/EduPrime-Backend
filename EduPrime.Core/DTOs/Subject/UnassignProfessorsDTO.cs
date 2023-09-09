using EduPrime.Core.Enums.Subject;

namespace EduPrime.Core.DTOs.Subject
{
    public class UnassignProfessorsDTO
    {
        public int SubjectId { get; set; }

        public UnassignProfessorsActionEnum UnassignAction { get; set; } = UnassignProfessorsActionEnum.NotAll;

        public List<int> ProfessorIds { get; set; }
    }
}
