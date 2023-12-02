using AutoMapper;
using EduPrime.Api.Attributes;
using EduPrime.Api.Response;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Shared;
using EduPrime.Core.DTOs.Student;
using EduPrime.Core.Entities;
using EduPrime.Core.Enums;
using EduPrime.Core.Enums.Shared;
using EduPrime.Core.Enums.Student;
using EduPrime.Core.Exceptions;
using EduPrime.Infrastructure.AzureServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EduPrime.Api.Controllers
{
    [Route("api/students/v1")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBlobStorageService _blobStorageService;
        private readonly IFileHelper _fileHelper;
        private readonly IMapper _mapper;
        private readonly AzureSettings _azureSettings;

        public StudentsController(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IFileHelper fileHelper,
            IOptions<AzureSettings> azureSettings,
            IBlobStorageService blobStorageService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileHelper = fileHelper;
            _azureSettings = azureSettings.Value;
            _blobStorageService = blobStorageService;
        }

        /// <summary>
        /// End point to return all students
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet("get-students")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetStudents([FromQuery] PaginationDTO paginationDTO)
        {
            var students = (await _unitOfWork.StudentRepository.GetStudentsWithAssignmentsAsync())
                .Skip((paginationDTO.CurrentPage - 1) * paginationDTO.QuantityPerPage)
                .Take(paginationDTO.QuantityPerPage)
                .ToList();
            var studentsDTO = _mapper.Map<List<StudentDTO>>(students);

            return Ok(new ApiResponse<List<StudentDTO>>(studentsDTO));
        }

        /// <summary>
        /// End point to get a student by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("get-student/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var student = await _unitOfWork.StudentRepository.GetStudentWithAssignmentsAsync(id);
            if (student is null)
            {
                return NotFound();
            }
            var studentDTO = _mapper.Map<StudentDTO>(student);
            var response = new ApiResponse<StudentDTO>(studentDTO);

            return Ok(response);
        }

        /// <summary>
        /// End point to create a subject
        /// </summary>
        /// <param name="createStudentDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("create-student")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateStudent([FromBody] CreateStudentDTO createStudentDTO)
        {
            var student = _mapper.Map<Student>(createStudentDTO);

            try
            {
                await _unitOfWork.StudentRepository.AddAsync(student);
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
        /// End point to assign subjects to a student
        /// </summary>
        /// <param name="assignSubjectsDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("assign-subjects")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AssignSubjects([FromBody] AssignSubjectsDTO assignSubjectsDTO)
        {
            if (!(await _unitOfWork.StudentRepository.ExistsAnyStudent(assignSubjectsDTO.StudentId)))
            {
                throw new BadRequestException($"The student with id {assignSubjectsDTO.StudentId} does not exist.");
            }

            if (assignSubjectsDTO.SubjectIds.Count() == 0)
            {
                throw new BadRequestException("Please assign at least 1 subject.");
            }

            assignSubjectsDTO.SubjectIds = assignSubjectsDTO.SubjectIds.Distinct().ToList();

            var student = await _unitOfWork.StudentRepository.GetStudentWithAssignmentsAsync(assignSubjectsDTO.StudentId);

            var isValidSubjectIds = await ValidateSubjectIds(assignSubjectsDTO.SubjectIds, student);
            if (!isValidSubjectIds.Item1)
            {
                throw new BadRequestException(isValidSubjectIds.Item2);
            }

            foreach (var subjectId in assignSubjectsDTO.SubjectIds)
            {
                var studentSubject = new StudentSubject
                {
                    StudentId = student.Id,
                    SubjectId = subjectId
                };

                student.StudentsSubjects.Add(studentSubject);
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
        /// End point to upload a picture for a student
        /// </summary>
        /// <param name="uploadStudentFileDTO"></param>
        /// <param name="studentId"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPost("upload-student-picture/{studentId:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> UploadStudentPicture([FromBody] UploadStudentFileDTO uploadStudentFileDTO, int studentId)
        {
            var student = await _unitOfWork.StudentRepository.GetByIdAsync(studentId);
            if (student is null)
            {
                throw new BadRequestException($"The student with id {studentId} does not exist.");
            }

            var validBase64Image = _fileHelper.IsValidBase64Image(uploadStudentFileDTO.fileBase64); ;
            if (!validBase64Image.Item1)
            {
                throw new BadRequestException("The file must be a png or jpg image.");
            }

            try
            {
                if (!string.IsNullOrEmpty(uploadStudentFileDTO.fileBase64))
                {
                    var pictureFileName = GeneratePictureFileName($"picture.{validBase64Image.Item2}", student);
                    student.PictureURL = await _blobStorageService.UploadFileBlobAsync(pictureFileName, uploadStudentFileDTO.fileBase64, AzureContainerEnum.StudentsPictures);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    throw new Exception();
                }

                var studentDTO = _mapper.Map<StudentDTO>(student);
                var response = new ApiResponse<StudentDTO>(studentDTO);

                return Ok(response);
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while uploading the resource.");
            }
        }

        /// <summary>
        /// End point to unassign subjects from a student
        /// </summary>
        /// <param name="unassignSubjectsDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("unassign-subjects")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UnassignSubjects([FromBody] UnassignSubjectsDTO unassignSubjectsDTO)
        {
            if (!(await _unitOfWork.StudentRepository.ExistsAnyStudent(unassignSubjectsDTO.StudentId)))
            {
                throw new BadRequestException($"The student with id {unassignSubjectsDTO.StudentId} does not exist.");
            }

            var student = await _unitOfWork.StudentRepository.GetStudentWithAssignmentsAsync(unassignSubjectsDTO.StudentId);

            // Unassign all subjects from the student
            if (unassignSubjectsDTO.UnassignAction == UnassignSubjectsActionEnum.All)
            {
                student.StudentsSubjects.Clear();
            }

            // Unassign certain subjects from the student
            if (unassignSubjectsDTO.UnassignAction == UnassignSubjectsActionEnum.NotAll)
            {
                if (unassignSubjectsDTO.SubjectIds.Any())
                {
                    unassignSubjectsDTO.SubjectIds = unassignSubjectsDTO.SubjectIds.Distinct().ToList();

                    var isValidSubjectsIds = await ValidateSubjectIds(unassignSubjectsDTO.SubjectIds, student);
                    if (!isValidSubjectsIds.Item1)
                    {
                        throw new BadRequestException(isValidSubjectsIds.Item2);
                    }

                    foreach (var subjectId in unassignSubjectsDTO.SubjectIds)
                    {
                        var studentSubject = student.StudentsSubjects.FirstOrDefault(ss => ss.SubjectId == subjectId);
                        if (studentSubject is not null)
                        {
                            student.StudentsSubjects.Remove(studentSubject);
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
        /// End point to update student assignment notes
        /// </summary>
        /// <param name="updateStudentAssignmentDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("update-student-assignment")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateStudentAssignment([FromBody] UpdateStudentAssignmentDTO updateStudentAssignmentDTO)
        {
            var studentDB = await _unitOfWork.StudentRepository.GetStudentWithAssignmentsAsync(updateStudentAssignmentDTO.StudentId);
            var subjectDB = await _unitOfWork.SubjectRepository.GetByIdAsync(updateStudentAssignmentDTO.SubjectId);

            // Validate that the student exists
            if (studentDB is null)
            {
                throw new BadRequestException($"The student with id {updateStudentAssignmentDTO.StudentId} does not exist.");
            }

            // Validate that the subject exists
            if (subjectDB is null)
            {
                throw new BadRequestException($"The subject with id {updateStudentAssignmentDTO.SubjectId} does not exist.");
            }

            // Validate that the student is currently assigned to the subject
            var assignedSubjects = new List<Subject>();
            foreach (var studentSubject in studentDB.StudentsSubjects)
            {
                assignedSubjects.Add(studentSubject.Subject);
            }

            if (!assignedSubjects.Contains(subjectDB))
            {
                throw new BadRequestException($"The student with id {updateStudentAssignmentDTO.StudentId} is not assigned to the subject with id {subjectDB.Id}");
            }

            var studentSubjectToUpdate = studentDB.StudentsSubjects.First(ss => ss.SubjectId == subjectDB.Id);
            studentSubjectToUpdate.FirstGrade = updateStudentAssignmentDTO.FirstGrade;
            studentSubjectToUpdate.SecondGrade = updateStudentAssignmentDTO.SecondGrade;
            studentSubjectToUpdate.FinalGrade = updateStudentAssignmentDTO.FinalGrade;
            studentSubjectToUpdate.Status = updateStudentAssignmentDTO.Status;

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
        /// End point to update a student
        /// </summary>
        /// <param name="updateStudentDTO"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpPut("update-student")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateStudent([FromBody] UpdateStudentDTO updateStudentDTO)
        {
            var studentDB = await _unitOfWork.StudentRepository.GetByIdAsync(updateStudentDTO.Id);
            if (studentDB is null)
            {
                throw new BadRequestException($"The student with id {updateStudentDTO.Id} does not exist.");
            }

            studentDB = _mapper.Map(updateStudentDTO, studentDB);
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
        /// End point to delete a student by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        /// <exception cref="InternalServerException"></exception>
        [AuthorizeRoles(
           nameof(RoleTypeEnum.Primary),
           nameof(RoleTypeEnum.Admin),
           nameof(RoleTypeEnum.Standard))]
        [HttpDelete("delete-student/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var studentDB = await _unitOfWork.StudentRepository.GetByIdAsync(id);
            if (studentDB is null)
            {
                throw new BadRequestException($"The student with id {id} does not exist.");
            }

            try
            {
                await _unitOfWork.StudentRepository.Delete(studentDB.Id);
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
        /// Generates a unique file picture name.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="student"></param>
        /// <returns></returns>
        private string GeneratePictureFileName(string fileName, Student student)
        {
            string guid = Guid.NewGuid().ToString();
            string documentName = $"{guid}{student.Name}{student.Surname}{fileName}";
            return documentName.Replace(" ", "");
        }

        /// <summary>
        /// Validates that each subject id exists in database
        /// </summary>
        /// <param name="subjectIds"></param>
        /// <returns></returns>
        private async Task<(bool, string)> ValidateSubjectIds(List<int> subjectIds, Student student)
        {
            bool isValidSubjectIds = true;
            int studentCurrentSemester = (int)student.CurrentSemester;
            string invalidReason = string.Empty;

            foreach (var subjectId in subjectIds)
            {
                var subject = await _unitOfWork.SubjectRepository.GetByIdAsync(subjectId);
                if (subject is null)
                {
                    isValidSubjectIds = false;
                    invalidReason = $"The subject with id {subjectId} does not exist.";
                    break;
                }
                int subjectAvailableSemester = (int)subject.AvailableSemester;
                if (studentCurrentSemester < subjectAvailableSemester)
                {
                    isValidSubjectIds = false;
                    invalidReason = $"The subject with id {subjectId} is only available for {subjectAvailableSemester}° semester students.";
                    break;
                }
            }

            return (isValidSubjectIds, invalidReason);
        }
    }
}
