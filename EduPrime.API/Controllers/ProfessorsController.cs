using AutoMapper;
using EduPrime.API.Attributes;
using EduPrime.API.Response;
using EduPrime.Core.DTOs.Professor;
using EduPrime.Core.Entities;
using EduPrime.Core.Enums;
using EduPrime.Core.Exceptions;
using EduPrime.Infrastructure.Repository;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        [HttpGet("get-professors")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetProfessors()
        {
            var professors = await _unitOfWork.ProfessorRepository.GetProfessorsWithEmployeeAsync();
            var professorsDTO = _mapper.Map<List<ProfessorDTO>>(professors);

            return Ok(new ApiResponse<List<ProfessorDTO>>(professorsDTO));
        }


        /// <summary>
        /// End point to get an employee by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("get-professor/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProfessorById(int id)
        {
            var professor = await _unitOfWork.ProfessorRepository.GetProfessorWithEmployeeAsync(id);
            if (professor is null)
            {
                return NotFound();
            }
            var professorDTO = _mapper.Map<ProfessorDTO>(professor);
            var response = new ApiResponse<ProfessorDTO>(professorDTO);

            return Ok(response);
        }

        /// <summary>
        /// End point to create a professor
        /// </summary>
        /// <param name="createProfessorDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("create-professor")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateProfessor([FromBody] CreateProfessorDTO createProfessorDTO)
        {
            if (!(await _unitOfWork.EmployeeRepository.ExistsAnyEmployee(createProfessorDTO.EmployeeId)))
            {
                throw new BadRequestException($"The employee with id {createProfessorDTO.EmployeeId} does not exist.");
            }

            var employee = await _unitOfWork.EmployeeRepository.GetEmployeeAsync(createProfessorDTO.EmployeeId);

            var areas = await _unitOfWork.AreaRepository.GetAllAsync();
            var professorArea = areas.FirstOrDefault(area => area.Name.ToLower().Contains("professor"));

            if (professorArea is not null)
            {
                if (!employee.Areas.Any(a => a.Id == professorArea.Id))
                {
                    throw new BadRequestException($"The employee {employee.Name} {employee.Surname} is not assigned to a professor area.");
                }
            } 
            else
            {
                throw new BadRequestException("There is not area for professor.");
            }
            var professor = _mapper.Map<Professor>(createProfessorDTO);
            try
            {
                await _unitOfWork.ProfessorRepository.AddAsync(professor);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while creating the resource.");
            }

            var response = new ApiResponse<ProfessorDTO>(_mapper.Map<ProfessorDTO>(professor))
            {
                Status = StatusCodes.Status201Created,
            };

            return Ok(response);
        }

        /// <summary>
        /// End point to update a professor
        /// </summary>
        /// <param name="updateProfessorDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("update-professor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateEmployee([FromBody] UpdateProfessorDTO updateProfessorDTO)
        {
            var professorDB = await _unitOfWork.ProfessorRepository.GetByIdAsync(updateProfessorDTO.Id);
            if (professorDB is null)
            {
                throw new BadRequestException($"The professor with id {updateProfessorDTO.Id} does not exist.");
            }

            professorDB = _mapper.Map(updateProfessorDTO, professorDB);
            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while updating the resource.");
            }

            var response = new ApiResponse<object>(null);
            return Ok(response);
        }

        /// <summary>
        /// End point to delete a professor by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpDelete("delete-professor/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
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
                await _unitOfWork.ProfessorRepository.Delete(professorDB.Id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while deleting the resource.");
            }

            var response = new ApiResponse<object>(null);
            return Ok(response);
        }
    }
}
