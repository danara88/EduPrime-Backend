namespace EduPrime.Core.DTOs.Subject
{
    public class AssignProfessorsDTO
    {
        public int SubjectId { get; set; }

        public List<int> ProfessorIds { get; set; }
    }
}
