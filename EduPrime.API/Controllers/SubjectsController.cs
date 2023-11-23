using AutoMapper;
using EduPrime.Api.Attributes;
using EduPrime.Api.Response;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Shared;
using EduPrime.Core.DTOs.Subject;
using EduPrime.Core.Entities;
using EduPrime.Core.Enums;
using EduPrime.Core.Enums.Subject;
using EduPrime.Core.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EduPrime.Api.Controllers
{
    [Route("api/subjects/v1")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SubjectsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        /// <summary>
        /// End point to return subjects paginated
        /// </summary>
        /// <param name="paginationDTO"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("get-subjects")]
        [ResponseCache(CacheProfileName = "HalfMinuteCache")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetSubjects([FromQuery] PaginationDTO paginationDTO)
        {
            var subjects = (await _unitOfWork.SubjectRepository.GetSubjectsWithProfessorsAsync())
                .Skip((paginationDTO.CurrentPage - 1) * paginationDTO.QuantityPerPage)
                .Take(paginationDTO.QuantityPerPage)
                .ToList();
            var subjectsDTO = _mapper.Map<List<SubjectDTO>>(subjects);
             
            return Ok(new ApiResponse<List<SubjectDTO>>(subjectsDTO));
        }

        /// <summary>
        /// End point to get a subject by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("get-subject/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetSubjectById(int id)
        {
            var subject = await _unitOfWork.SubjectRepository.GetSubjectWithProfessorsAsync(id);
            if (subject is null)
            {
                return NotFound();
            }
            var subjectDTO = _mapper.Map<SubjectDTO>(subject);
            var response = new ApiResponse<SubjectDTO>(subjectDTO);

            return Ok(response);
        }

        /// <summary>
        /// End point to crate a subject
        /// </summary>
        /// <param name="createSubjectDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("create-subject")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateSubject([FromBody] CreateSubjectDTO createSubjectDTO)
        {
            if (await _unitOfWork.SubjectRepository.ExistsAnySubject(createSubjectDTO.Name))
            {
                throw new BadRequestException($"The subject with name {createSubjectDTO.Name} already exists.");
            }

            var subject = _mapper.Map<Subject>(createSubjectDTO);

            if (createSubjectDTO.ProfessorIds is not null && createSubjectDTO.ProfessorIds.Any())
            {
                subject.ProfessorsSubjects = new List<ProfessorSubject>() { };
                createSubjectDTO.ProfessorIds = createSubjectDTO.ProfessorIds
                    .Distinct()
                    .ToList();

                if (createSubjectDTO.ProfessorIds.Count > 2)
                {
                    throw new BadRequestException("You can add maximum 2 professors per subject.");
                }

                var isValidProfessorIds = await ValidProfessorIds(createSubjectDTO.ProfessorIds);

                if (!isValidProfessorIds.Item1)
                {
                    throw new BadRequestException($"The professor with id {isValidProfessorIds.Item2} does not exist.");
                }

                foreach (var professorId in createSubjectDTO.ProfessorIds)
                {
                    var professorSubject = new ProfessorSubject
                    {
                        SubjectId = subject.Id,
                        ProfessorId = professorId
                    };

                    subject.ProfessorsSubjects.Add(professorSubject);
                }
            }

            try
            {
                await _unitOfWork.SubjectRepository.AddAsync(subject);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while creating the resource.");
            }

            var response = new ApiResponse<object>(null)
            {
                Status = StatusCodes.Status201Created,
            };

            return Ok(response);
        }

        /// <summary>
        /// End point to update a subject
        /// </summary>
        /// <param name="updateSubjectDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("update-subject")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateSubject([FromBody] UpdateSubjectDTO updateSubjectDTO)
        {
            var subjectDB = await _unitOfWork.SubjectRepository.GetByIdAsync(updateSubjectDTO.Id);
            if (subjectDB is null)
            {
                throw new BadRequestException($"The subject with id {updateSubjectDTO.Id} does not exist.");
            }

            subjectDB = _mapper.Map(updateSubjectDTO, subjectDB);
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
        /// End point to unassign professors
        /// </summary>
        /// <param name="unassignProfessorsDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("unassign-professors")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UnassignProfessors([FromBody] UnassignProfessorsDTO unassignProfessorsDTO)
        {
            if (!(await _unitOfWork.SubjectRepository.ExistsAnySubject(unassignProfessorsDTO.SubjectId)))
            {
                throw new BadRequestException($"The subject with id {unassignProfessorsDTO.SubjectId} does not exist.");
            }

            var subject = await _unitOfWork.SubjectRepository.GetSubjectWithProfessorsAsync(unassignProfessorsDTO.SubjectId);

            // Unassign all professors from the subject
            if (unassignProfessorsDTO.UnassignAction == UnassignProfessorsActionEnum.All)
            {
                subject.ProfessorsSubjects.Clear();
            }

            // Unassign certain professors from the subject
            if (unassignProfessorsDTO.UnassignAction == UnassignProfessorsActionEnum.NotAll)
            {
                if (unassignProfessorsDTO.ProfessorIds.Any())
                {
                    unassignProfessorsDTO.ProfessorIds = unassignProfessorsDTO.ProfessorIds.Distinct().ToList();

                    if (unassignProfessorsDTO.ProfessorIds.Count() > 2)
                    {
                        throw new BadRequestException($"You can only unassign maximum 2 professors per subject.");
                    }

                    var isValidProfessorIds = await ValidProfessorIds(unassignProfessorsDTO.ProfessorIds);
                    if (!isValidProfessorIds.Item1)
                    {
                        throw new BadRequestException($"The professor with id {isValidProfessorIds.Item2} does not exist.");
                    }

                    foreach (var professorId in unassignProfessorsDTO.ProfessorIds)
                    {
                        var professorSubject = subject.ProfessorsSubjects.FirstOrDefault(ps => ps.ProfessorId == professorId);
                        if (professorSubject is not null)
                        {
                            subject.ProfessorsSubjects.Remove(professorSubject);
                        }
                    }
                }
            }

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
        /// End point to assign professors
        /// </summary>
        /// <param name="assignProfessorsDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("assign-professors")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AssignProfessors([FromBody] AssignProfessorsDTO assignProfessorsDTO)
        {
            if (!(await _unitOfWork.SubjectRepository.ExistsAnySubject(assignProfessorsDTO.SubjectId)))
            {
                throw new BadRequestException($"The subject with id {assignProfessorsDTO.SubjectId} does not exist.");
            }

            if (assignProfessorsDTO.ProfessorIds.Count() == 0)
            {
                throw new BadRequestException("Please assign at least 1 professor.");
            }

            assignProfessorsDTO.ProfessorIds = assignProfessorsDTO.ProfessorIds.Distinct().ToList();
            if (assignProfessorsDTO.ProfessorIds.Count() > 2)
            {
                throw new BadRequestException($"You can only assign maximum 2 professors per subject.");
            }

            var isValidProfessorIds = await ValidProfessorIds(assignProfessorsDTO.ProfessorIds);
            if (!isValidProfessorIds.Item1)
            {
                throw new BadRequestException($"The professor with id {isValidProfessorIds.Item2} does not exist.");
            }

            var subject = await _unitOfWork.SubjectRepository.GetSubjectWithProfessorsAsync(assignProfessorsDTO.SubjectId);

            switch (subject.ProfessorsSubjects.Count())
            {
                case 2:
                    throw new BadRequestException($"The subject with id {assignProfessorsDTO.SubjectId} is already assigned to 2 professors. Please unassign professors to continue.");
                case 1:
                    if (assignProfessorsDTO.ProfessorIds.Count() > 1)
                    {
                        throw new BadRequestException($"You are trying to add more than 1 professor. The subject with id {assignProfessorsDTO.SubjectId} is already assigned to 1 professor.");
                    }
                    break;
            }

            foreach (var professorId in assignProfessorsDTO.ProfessorIds)
            {
                var professorSubject = new ProfessorSubject
                {
                    SubjectId = subject.Id,
                    ProfessorId = professorId
                };

                subject.ProfessorsSubjects.Add(professorSubject);
            }

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while creating the resource.");
            }

            var response = new ApiResponse<object>(null);
            return Ok(response);
        }

        /// <summary>
        /// End point to delete a subject by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpDelete("delete-subject/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteSubject(int id)
        {
            var subjectDB = await _unitOfWork.SubjectRepository.GetByIdAsync(id);
            if (subjectDB is null)
            {
                throw new BadRequestException($"The subject with id {id} does not exist.");
            }

            try
            {
                await _unitOfWork.SubjectRepository.Delete(subjectDB.Id);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while deleting the resource.");
            }

            var response = new ApiResponse<object>(null);
            return Ok(response);
        }

        /// <summary>
        /// Validates that each professor id exists in database
        /// </summary>
        /// <param name="professorIds"></param>
        /// <returns></returns>
        private async Task<(bool, int)> ValidProfessorIds(List<int> professorIds)
        {
            int invalidProfessorId = 0;
            bool isValidProfessorIds = true;

            foreach (var professorId in professorIds)
            {
                if (!(await _unitOfWork.ProfessorRepository.ExistsAnyProfessor(professorId)))
                {
                    isValidProfessorIds = false;
                    invalidProfessorId = professorId;
                    break;
                }
            }

            return (isValidProfessorIds, invalidProfessorId);
        }
    }
}
