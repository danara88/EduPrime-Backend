using AutoMapper;
using MediatR;
using ErrorOr;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Student;
using EduPrime.Core.Enums.Shared;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Students;
using EduPrime.Core.Common;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Upload student picture command handler
    /// </summary>
    public class UploadStudentPictureCommandHandler : IRequestHandler<UploadStudentPictureCommand, ErrorOr<StudentDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileHelper _fileHelper;
        private readonly IBlobStorageService _blobStorageService;

        public UploadStudentPictureCommandHandler(
            IUnitOfWork unitOfWork,
            IFileHelper fileHelper,
            IBlobStorageService blobStorageService,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _fileHelper = fileHelper;
            _blobStorageService = blobStorageService;
            _mapper = mapper;
        }

        public async Task<ErrorOr<StudentDTO>> Handle(UploadStudentPictureCommand request, CancellationToken cancellationToken)
        {
            var student = await _unitOfWork.StudentRepository.GetByIdAsync(request.uploadStudentFileDTO.studentId);
            if (student is null)
            {
                return StudentErrors.StudentWithIdDoesNotExist(request.uploadStudentFileDTO.studentId);
            }

            var validBase64Image = _fileHelper.IsValidBase64Image(request.uploadStudentFileDTO.fileBase64);
            if (!validBase64Image.Item1)
            {
                return CommonErrors.InvalidFileExtension();
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
                    return CommonErrors.FileOrDocumentNotFound;
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
