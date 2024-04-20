using ErrorOr;
using MediatR;
using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Employees;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Update employee command handler
    /// </summary>
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, ErrorOr<EmployeeDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateEmployeeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<EmployeeDTO>> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employeeDB = await _unitOfWork.EmployeeRepository.GetByIdAsync(request.updateEmployeeDTO.Id);
            if (employeeDB is null)
            {
                return EmployeeErrors.EmployeeWithIdDoesNotExist(request.updateEmployeeDTO.Id);
            }

            employeeDB = _mapper.Map(request.updateEmployeeDTO, employeeDB);
            try
            {
                await _unitOfWork.SaveChangesAsync();
                var employeeDTO = _mapper.Map<EmployeeDTO>(employeeDB);

                return employeeDTO;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while updating the resource.");
            }
        }
    }
}
