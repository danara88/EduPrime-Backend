using System.Net;

namespace EduPrime.Api.Response
{
    /// <summary>
    /// Common API response with message
    /// </summary>
    public class ApiMessageResponse
    {
        public string Message { get; set; }
        public int Status { get; set; } = (int)HttpStatusCode.OK;
        public bool Success { get; set; } = true;

        public ApiMessageResponse(string message)
        {
            Message = message;
        }
    }
}
