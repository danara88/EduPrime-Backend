namespace EduPrime.Core.Exceptions
{
    /// <summary>
    /// Bad request exception
    /// </summary>
    public class BadRequestException : Exception
    {
        public BadRequestException() { }

        public BadRequestException(string message) : base(message) { }
    }
}
