namespace EduPrime.Core.Entities
{
    /// <summary>
    /// Represents the response when an API fails
    /// </summary>
    public class ApiFailure
    {
        public string Message { get; set; }

        public int Status { get; set; }

        public bool Success { get; set; }
    }
}
