using AutoMapper;
using EduPrime.API.Attributes;
using EduPrime.API.Response;
using EduPrime.Core.DTOs.Role;
using EduPrime.Core.Entities;
using EduPrime.Core.Enums;
using EduPrime.Core.Exceptions;
using EduPrime.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EduPrime.API.Controllers
{
    /// <summary>
    /// NOTE:
    /// If you want to update the name of a role, please talk to the DB administrator.
    /// </summary>
    [Route("api/roles/v1")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RolesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        /// <summary>
        /// End point to return all the roles
        /// </summary>
        /// <returns></returns>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary), nameof(RoleTypeEnum.Admin))]
        [HttpGet("get-roles")]
        [ResponseCache(CacheProfileName = "OneMinuteCache")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _unitOfWork.RoleRepository.GetAllAsync();
            var rolesDTO = _mapper.Map<List<RoleDTO>>(roles);

            return Ok(new ApiResponse<List<RoleDTO>>(rolesDTO));
        }

        /// <summary>
        /// End point to get a role by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary), nameof(RoleTypeEnum.Admin))]
        [HttpGet("get-role/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetRoleById(int id)
        {
            var role = await _unitOfWork.RoleRepository.GetByIdWithUsersAsync(id);
            if (role is null)
            {
                return NotFound();
            }
            var roleDTO = _mapper.Map<RoleWithUsersDTO>(role);
            var response = new ApiResponse<RoleWithUsersDTO>(roleDTO);

            return Ok(response);
        }

        /// <summary>
        /// End point to create a role.
        /// NOTE: Be sure to add your new role into the enum: RoleTypeEnum.
        /// </summary>
        /// <param name="createRoleDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary))]
        [HttpPost("create-role")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateRole([FromBody] CreateRoleDTO createRoleDTO)
        {
            if (await _unitOfWork.RoleRepository.ExistsAnyRoleAsync(createRoleDTO.Name))
            {
                throw new BadRequestException($"The role with name {createRoleDTO.Name} already exists.");
            }

            var role = _mapper.Map<Role>(createRoleDTO);
            try
            {
                await _unitOfWork.RoleRepository.AddAsync(role);
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
        /// End point to update the assigned role of a user
        /// </summary>
        /// <param name="updateUserRoleDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary))]
        [HttpPut("update-user-role")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateUserRole([FromBody] UpdateUserRoleDTO updateUserRoleDTO)
        {
            var user = await _unitOfWork.UserRepository.GetByIdAsync(updateUserRoleDTO.UserId);
            if (user is null)
            {
                throw new BadRequestException($"The user with id {updateUserRoleDTO.UserId} does not exist.");
            }

            if (!(await _unitOfWork.RoleRepository.ExistsAnyRoleAsync(updateUserRoleDTO.RoleId)))
            {
                throw new BadRequestException($"The role with id {updateUserRoleDTO.RoleId} does not exist.");
            }

            user.RoleId = updateUserRoleDTO.RoleId;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while creating the resource.");
            }

            var response = new ApiResponse<object>("");
            return Ok(response);
        }

        /// <summary>
        /// End point to delete a role.
        /// NOTE: Be carefull. It will delete on cascade.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(nameof(RoleTypeEnum.Primary))]
        [HttpDelete("delete-role/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var roleDB = await _unitOfWork.RoleRepository.GetByIdAsync(id);
            if (roleDB is null)
            {
                throw new BadRequestException($"The role with id {id} does not exist.");
            }

            try
            {
                await _unitOfWork.RoleRepository.Delete(roleDB.Id);
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
