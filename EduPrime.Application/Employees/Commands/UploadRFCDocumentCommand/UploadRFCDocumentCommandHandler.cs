using ErrorOr;
using MediatR;
using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Enums.Shared;
using EduPrime.Core.Exceptions;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Upload RFC document command handler
    /// </summary>
    public class UploadRFCDocumentCommandHandler : IRequestHandler<UploadRFCDocumentCommand, ErrorOr<EmployeeDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IFileHelper _fileHelper;
        private readonly IBlobStorageService _blobStorageService;

        public UploadRFCDocumentCommandHandler(
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

        public async Task<ErrorOr<EmployeeDTO>> Handle(UploadRFCDocumentCommand request, CancellationToken cancellationToken)
        {
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(request.uploadEmployeeFileDTO.employeeId);
            if (employee is null)
            {
                return EmployeeErrors.EmployeeWithIdDoesNotExist(request.uploadEmployeeFileDTO.employeeId);
            }

            if (!_fileHelper.IsValidBase64Pdf(request.uploadEmployeeFileDTO.fileBase64))
            {
                var allowedExtensions = new string[] { "pdf" };
                return CommonErrors.InvalidFileExtension(allowedExtensions);
            }

            try
            {
                if (!string.IsNullOrEmpty(request.uploadEmployeeFileDTO.fileBase64))
                {
                    string newFileName = _fileHelper.GenerateEmployeeFileName("rfc.pdf", employee);
                    employee.RfcDocument = newFileName;
                    await _blobStorageService.UploadFileBlobAsync(newFileName, request.uploadEmployeeFileDTO.fileBase64, AzureContainerEnum.EmployeesRFCs);
                    await _unitOfWork.SaveChangesAsync();
                }
                else
                {
                    return CommonErrors.FileOrDocumentNotFound;
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
