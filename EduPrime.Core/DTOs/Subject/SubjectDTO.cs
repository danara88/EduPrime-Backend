using EduPrime.Core.DTOs.Professor;
using EduPrime.Core.Enums;

namespace EduPrime.Core.DTOs.Subject
{
    public class SubjectDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public SemesterTypeEnum AvailableSemester { get; set; }

        private List<ProfessorDTO> _professors { get; set; }

        public List<ProfessorDTO> Professors
        {
            get => _professors;
            set => _professors = (value is null || value.Count == 0) ? null : value;
        }
    }
}
