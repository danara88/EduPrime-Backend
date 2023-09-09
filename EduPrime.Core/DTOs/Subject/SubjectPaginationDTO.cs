namespace EduPrime.Core.DTOs.Subject
{
    public class SubjectPaginationDTO
    {
        public int CurrentPage { get; set; } = 1;

        public int QuantityPerPage { get; set; } = 5;
    }
}
