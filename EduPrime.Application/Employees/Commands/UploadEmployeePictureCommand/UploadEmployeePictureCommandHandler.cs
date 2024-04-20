using ErrorOr;
using MediatR;
using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Enums.Shared;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Employees;
using EduPrime.Core.Common;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Upload employee picture command handler
    /// </summary>
    public class UploadEmployeePictureCommandHandler : IRequestHandler<UploadEmployeePictureCommand, ErrorOr<EmployeeDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileHelper _fileHelper;
        private readonly IBlobStorageService _blobStorageService;

        public UploadEmployeePictureCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IFileHelper fileHelper,
            IBlobStorageService blobStorageService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileHelper = fileHelper;
            _blobStorageService = blobStorageService;
        }

        public async Task<ErrorOr<EmployeeDTO>> Handle(UploadEmployeePictureCommand request, CancellationToken cancellationToken)
        {
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(request.uploadEmployeeFileDTO.employeeId);
            if (employee is null)
            {
                return EmployeeErrors.EmployeeWithIdDoesNotExist(request.uploadEmployeeFileDTO.employeeId);
            }

            var validBase64Image = _fileHelper.IsValidBase64Image(request.uploadEmployeeFileDTO.fileBase64);
            if (!validBase64Image.Item1)
            {
                return CommonErrors.InvalidFileExtension();
            }

            try
            {
                if (!string.IsNullOrEmpty(request.uploadEmployeeFileDTO.fileBase64))
                {
                    var pictureFileName = _fileHelper.GenerateEmployeeFileName($"picture.{validBase64Image.Item2}", employee);
                    employee.PictureURL = await _blobStorageService.UploadFileBlobAsync(pictureFileName, request.uploadEmployeeFileDTO.fileBase64, AzureContainerEnum.EmployeesPictures);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    throw new Exception();
                }

                var employeeDTO = _mapper.Map<EmployeeDTO>(employee);

                return employeeDTO;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while uploading the resource.");
            }
        }
    }
}
