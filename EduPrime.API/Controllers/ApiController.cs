using System.ComponentModel.DataAnnotations.Schema;
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

            if (errors.All(error => error.Type == ErrorType.Validation))
            {
                return ValidationProblem(errors);
            }

            return Problem(errors[0]);
        }

        /// <summary>
        /// Handles one single error and return correct error response
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
                _ => StatusCodes.Status500InternalServerError
            };

            return Problem(statusCode: statusCode, detail: error.Description);
        }

        /// <summary>
        /// Handler a list of errors
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

