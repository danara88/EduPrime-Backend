using System.Net;

namespace EduPrime.Api.Response
{
    /// <summary>
    /// Common API response
    /// </summary>
    public class ApiResponse<T>
    {
        public T Data { get; set; }
        public int Status { get; set; } = (int)HttpStatusCode.OK;
        public bool Success { get; set; } = true;

        public ApiResponse(T data)
        {
            Data = data;
        }
    }
}
