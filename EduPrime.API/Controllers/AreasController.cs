using AutoMapper;
using EduPrime.API.Response;
using EduPrime.Core.DTOs.Area;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using EduPrime.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EduPrime.API.Controllers
{
    [Route("api/areas/v1")]
    [ApiController]
    public class AreasController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AreasController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        /// <summary>
        /// End point to return all areas
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-areas")]
        [ResponseCache(CacheProfileName = "OneMinuteCache")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetAreas()
        {
            var areas = await _unitOfWork.AreaRepository.GetAllAsync();
            var areasDTO = _mapper.Map<List<AreaDTO>>(areas);

            return Ok(new ApiResponse<List<AreaDTO>>(areasDTO));
        }

        /// <summary>
        /// End point to get an area by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("get-area/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAreaById(int id)
        {
            var area = await _unitOfWork.AreaRepository.GetByIdAsync(id);
            if (area is null)
            {
                return NotFound();
            }
            var areaDTO = _mapper.Map<AreaDTO>(area);
            var response = new ApiResponse<AreaDTO>(areaDTO);

            return Ok(response);
        }

        /// <summary>
        /// End point to create an area
        /// </summary>
        /// <param name="createAreaDTO"></param>
        /// <returns></returns>
        [HttpPost("create-area")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateArea([FromBody] CreateAreaDTO createAreaDTO)
        {
            if (!ModelState.IsValid)
            {
                throw new BadRequestException("The inserted values are not valid.");
            }

            if (await _unitOfWork.AreaRepository.ExistsAnyArea(createAreaDTO.Name))
            {
                throw new BadRequestException($"The area with name {createAreaDTO.Name} already exists.");
            }

            var area = _mapper.Map<Area>(createAreaDTO);
            try
            {
                await _unitOfWork.AreaRepository.AddAsync(area);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while creating the resource.");
            }

            var response = new ApiResponse<object>("")
            {
                Status = StatusCodes.Status201Created,
            };

            return Ok(response);
        }

        /// <summary>
        /// End point to update an Area
        /// </summary>
        /// <param name="updateAreaDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [HttpPut("update-area")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateArea([FromBody] UpdateAreaDTO updateAreaDTO)
        {
            if (!ModelState.IsValid)
            {
                throw new BadRequestException("The inserted values are not valid.");
            }

            var areaDB = await _unitOfWork.AreaRepository.GetByIdAsync(updateAreaDTO.Id);
            if (areaDB is null)
            {
                throw new BadRequestException($"The area with id {updateAreaDTO.Id} does not exist.");
            }

            areaDB = _mapper.Map(updateAreaDTO, areaDB);
            areaDB.UpdatedOn = DateTime.Now;
            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while updating the resource.");
            }
           
            var response = new ApiResponse<object>("");
            return Ok(response);
        }

        /// <summary>
        /// End point to delete an Area
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [HttpDelete("delete-area/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteArea(int id)
        {
            var areaDB = await _unitOfWork.AreaRepository.GetByIdAsync(id);
            if (areaDB is null)
            {
                throw new BadRequestException($"The area with id {id} does not exist.");
            }

            try
            {
                _unitOfWork.AreaRepository.Delete(id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while deleting the resource.");
            }

            var response = new ApiResponse<object>("");
            return Ok(response);
        }

        /// <summary>
        /// End point to get areas with employees
        /// </summary>
        /// <returns></returns>
        [HttpGet("get-areas-with-employees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetAreasWithEmployees()
        {
            var areasWithEmployees = await _unitOfWork.AreaRepository.GetAreasWithEmployeesAsync();
            var areasWithEmployeesDTO = _mapper.Map<List<AreaWithEmployeesDTO>>(areasWithEmployees);
            var response = new ApiResponse<List<AreaWithEmployeesDTO>>(areasWithEmployeesDTO);

            return Ok(response);
        }
    }
}
