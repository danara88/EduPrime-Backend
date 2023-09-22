namespace EduPrime.Core.DTOs.Shared
{
    public class PaginationDTO
    {
        public int CurrentPage { get; set; } = 1;

        public int QuantityPerPage { get; set; } = 5;
    }
}
