using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Application.Professors.Interfaces;
using EduPrime.Core.DTOs.Student;
using EduPrime.Core.Enums.Shared;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Upload student picture command handler
    /// </summary>
    public class UploadStudentPictureCommandHandler : IRequestHandler<UploadStudentPictureCommand, StudentDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IProfessorService _professorService;
        private readonly IFileHelper _fileHelper;
        private readonly IBlobStorageService _blobStorageService;

        public UploadStudentPictureCommandHandler(
            IUnitOfWork unitOfWork,
            IProfessorService professorService,
            IFileHelper fileHelper,
            IBlobStorageService blobStorageService,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _professorService = professorService;
            _fileHelper = fileHelper;
            _blobStorageService = blobStorageService;
            _mapper = mapper;
        }

        public async Task<StudentDTO> Handle(UploadStudentPictureCommand request, CancellationToken cancellationToken)
        {
            var student = await _unitOfWork.StudentRepository.GetByIdAsync(request.uploadStudentFileDTO.studentId);
            if (student is null)
            {
                throw new NotFoundException($"The student with id {request.uploadStudentFileDTO.studentId} does not exist.");
            }

            var validBase64Image = _fileHelper.IsValidBase64Image(request.uploadStudentFileDTO.fileBase64);
            if (!validBase64Image.Item1)
            {
                throw new BadRequestException("The file must be a png or jpg image.");
            }

            try
            {
                if (!string.IsNullOrEmpty(request.uploadStudentFileDTO.fileBase64))
                {
                    var pictureFileName = _fileHelper.GenerateStudentFileName($"picture.{validBase64Image.Item2}", student);
                    student.PictureURL = await _blobStorageService.UploadFileBlobAsync(pictureFileName, request.uploadStudentFileDTO.fileBase64, AzureContainerEnum.StudentsPictures);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    throw new Exception();
                }

                var studentDTO = _mapper.Map<StudentDTO>(student);
                return studentDTO;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while uploading the resource.");
            }
        }
    }
}
