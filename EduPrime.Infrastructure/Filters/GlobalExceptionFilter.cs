using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace EduPrime.Infrastructure.Filters
{
    /// <summary>
    /// Global exception filter settings
    /// </summary>
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            OnBadRequestException(context);
            OnInternalServerException(context);
        }

        /// <summary>
        /// Configures bad request exception
        /// </summary>
        /// <param name="context"></param>
        private void OnBadRequestException(ExceptionContext context)
        {
            if (context.Exception.GetType() == typeof(BadRequestException))
            {
                var exception = (BadRequestException)context.Exception;

                var error = new ApiFailure
                {
                    Message = exception.Message,
                    Status = (int)HttpStatusCode.BadRequest,
                    Success = false
                };

                context.Result = new BadRequestObjectResult(error);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.ExceptionHandled = true;
            }
        }

        /// <summary>
        /// Configures the internal server exception
        /// </summary>
        /// <param name="context"></param>
        private void OnInternalServerException(ExceptionContext context)
        {
            if (context.Exception.GetType() == typeof(InternalServerException))
            {
                var exception = (InternalServerException)context.Exception;

                var error = new ApiFailure
                {
                    Message = exception.Message,
                    Status = (int)HttpStatusCode.InternalServerError,
                    Success = false
                };

                context.Result = new BadRequestObjectResult(error);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.ExceptionHandled = true;
            }
        }
    }
}
