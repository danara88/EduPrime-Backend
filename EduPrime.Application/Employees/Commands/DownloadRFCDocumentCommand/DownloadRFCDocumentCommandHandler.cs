using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Enums.Shared;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Employees;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Donwload RFC document command handler
    /// </summary>
    public class DownloadRFCDocumentCommandHandler : IRequestHandler<DownloadRFCDocumentCommand, ErrorOr<DownloadEmployeeRfcDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBlobStorageService _blobStorageService;

        public DownloadRFCDocumentCommandHandler(IUnitOfWork unitOfWork, IBlobStorageService blobStorageService)
        {
            _unitOfWork = unitOfWork;
            _blobStorageService = blobStorageService;
        }

        public async Task<ErrorOr<DownloadEmployeeRfcDTO>> Handle(DownloadRFCDocumentCommand request, CancellationToken cancellationToken)
        {
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(request.employeeId);
            if (employee is null)
            {
                return EmployeeErrors.EmployeeWithIdDoesNotExist(request.employeeId);
            }

            if (employee.RfcDocument is null)
            {
                return EmployeeErrors.EmployeeDoesNotHaveAnyAttachedRfcDocument;
            }

            try
            {
                Stream blobStream = await _blobStorageService.DownloadBlobInBrowserAsync(AzureContainerEnum.EmployeesRFCs, employee.RfcDocument);
                DownloadEmployeeRfcDTO donwloadEmployeeRfcDTO = new()
                {
                    employee = employee,
                    stream = blobStream
                };

                return donwloadEmployeeRfcDTO;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while downloading the resource.");
            }
        }
    }
}
