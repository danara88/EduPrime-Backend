using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace EduPrime.Api.Controllers
{

    /// <summary>
    /// Api controller class
    /// </summary>
    [ApiController]
    public class ApiController : ControllerBase
    {
        /// <summary>
        /// Handles a list of errors and return correct error response
        /// </summary>
        /// <param name="errors"></param>
        /// <returns></returns>
        protected IActionResult Problem(List<Error> errors)
        {
            if (errors.Count is 0)
            {
                return Problem();
            }

            // If all the errors are of type Validation and errors are more than 1
            if (errors.Count > 1 && errors.All(error => error.Type == ErrorType.Validation))
            {
                return ValidationProblem(errors);
            }

            // Call Problem method to map the correct error type when we have just 1 error
            return Problem(errors[0]);
        }

        /// <summary>
        /// Handles one single error and maps correct error status code
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        protected IActionResult Problem(Error error)
        {
            var statusCode = error.Type switch
            {
                ErrorType.Conflict => StatusCodes.Status409Conflict,
                ErrorType.NotFound => StatusCodes.Status404NotFound,
                ErrorType.Validation => StatusCodes.Status400BadRequest,
                ErrorType.Unauthorized => StatusCodes.Status401Unauthorized,
                ErrorType.Forbidden => StatusCodes.Status403Forbidden,
                _ => StatusCodes.Status500InternalServerError
            };

            return Problem(statusCode: statusCode, detail: error.Description);
        }

        /// <summary>
        /// Handles a list of validation errors
        /// </summary>
        /// <param name="errors"></param>
        /// <returns></returns>
        protected IActionResult ValidationProblem(List<Error> errors)
        {
            var modelStateDictionary = new ModelStateDictionary();

            foreach(var error in errors)
            {
                modelStateDictionary.AddModelError(error.Code, error.Description);
            }

            return ValidationProblem(modelStateDictionary);
        }
    }

}

