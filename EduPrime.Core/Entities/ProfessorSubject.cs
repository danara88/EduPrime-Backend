namespace EduPrime.Core.Entities
{
    /// <summary>
    /// ProfessorSubject Entity
    /// </summary>
    public class ProfessorSubject : BaseEntity
    {
        public int ProfessorId { get; set; }

        public int SubjectId { get; set; }

        public Professor Professor { get; set; }

        public Subject Subject { get; set; }
    }
}
