using AutoMapper;
using EduPrime.API.Response;
using EduPrime.Core.DTOs.Professor;
using EduPrime.Core.Exceptions;
using EduPrime.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EduPrime.API.Controllers
{
    [Route("api/professors/v1")]
    [ApiController]
    public class ProfessorsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ProfessorsController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// End point to return all professors
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-professors")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetProfessors()
        {
            var employeesWithProfessor = await _unitOfWork.EmployeeRepository.GetEmployeesWithProfessor();
            var employeesWithProfessorDTO = _mapper.Map<List<EmployeeAsProfessorDTO>>(employeesWithProfessor);

            return Ok(new ApiResponse<List<EmployeeAsProfessorDTO>>(employeesWithProfessorDTO));
        }

        /// <summary>
        /// End point to delete a professor by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [HttpDelete("delete-professor/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteProfessor(int id) 
        {
            var professorDB = await _unitOfWork.ProfessorRepository.GetByIdAsync(id);
            if (professorDB is null)
            {
                throw new BadRequestException($"The professor with id {id} does not exist.");
            }

            try
            {
                _unitOfWork.ProfessorRepository.Delete(id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while deleting the resource.");
            }

            var response = new ApiResponse<object>("");
            return Ok(response);
        }
    }
}
