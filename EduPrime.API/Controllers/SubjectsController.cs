using AutoMapper;
using EduPrime.API.Response;
using EduPrime.API.Services;
using EduPrime.Core.DTOs.Subject;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using EduPrime.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EduPrime.API.Controllers
{
    [Route("api/subjects/v1")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISubjectService _subjectService;
        private readonly IMapper _mapper;

        public SubjectsController(IUnitOfWork unitOfWork, IMapper mapper, ISubjectService subjectService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _subjectService = subjectService;
        }

        /// <summary>
        /// End point to return subjects paginated
        /// </summary>
        /// <param name="subjectPaginationDTO"></param>
        /// <returns></returns>
        [HttpGet("get-subjects")]
        [ResponseCache(CacheProfileName = "HalfMinuteCache")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetSubjects([FromQuery] SubjectPaginationDTO subjectPaginationDTO)
        {
            var subjects = (await _unitOfWork.SubjectRepository.GetSubjectsWithProfessorsAsync())
                .Skip((subjectPaginationDTO.CurrentPage - 1) * subjectPaginationDTO.QuantityPerPage)
                .Take(subjectPaginationDTO.QuantityPerPage)
                .ToList();
            var subjectsDTO = _mapper.Map<List<SubjectDTO>>(subjects);
             
            return Ok(new ApiResponse<List<SubjectDTO>>(subjectsDTO));
        }

        /// <summary>
        /// End point to get a subject by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("get-subject/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
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
        [HttpPost("create-subject")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateSubject([FromBody] CreateSubjectDTO createSubjectDTO)
        {
            if (!ModelState.IsValid)
            {
                throw new BadRequestException("The inserted values are not valid.");
            }

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

                var isValidProfessorIds = await _subjectService.ValidProfessorIds(createSubjectDTO.ProfessorIds);

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

            var response = new ApiResponse<object>("")
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
        [HttpPut("update-subject")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateSubject([FromBody] UpdateSubjectDTO updateSubjectDTO)
        {
            if (!ModelState.IsValid)
            {
                throw new BadRequestException("The inserted values are not valid.");
            }

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

            var response = new ApiResponse<object>("");
            return Ok(response);
        }

        /// <summary>
        /// End point to delete a subject by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [HttpDelete("delete-subject/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
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

            var response = new ApiResponse<object>("");
            return Ok(response);
        }
    }
}
