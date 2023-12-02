using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Enums.Shared;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Donwload RFC document command handler
    /// </summary>
    public class DownloadRFCDocumentCommandHandler : IRequestHandler<DownloadRFCDocumentCommand, DownloadEmployeeRfcDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBlobStorageService _blobStorageService;

        public DownloadRFCDocumentCommandHandler(IUnitOfWork unitOfWork, IBlobStorageService blobStorageService)
        {
            _unitOfWork = unitOfWork;
            _blobStorageService = blobStorageService;
        }

        public async Task<DownloadEmployeeRfcDTO> Handle(DownloadRFCDocumentCommand request, CancellationToken cancellationToken)
        {
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(request.employeeId);
            if (employee is null)
            {
                throw new NotFoundException($"The employee with id {request.employeeId} does not exist.");
            }

            if (employee.RfcDocument is null)
            {
                throw new BadRequestException($"The employee doesn't have any RFC document.");
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
                throw new InternalServerException("Something went wrong while uploading the resource.");
            }
        }
    }
}
