using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Update employee command handler
    /// </summary>
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, EmployeeDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateEmployeeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<EmployeeDTO> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employeeDB = await _unitOfWork.EmployeeRepository.GetByIdAsync(request.updateEmployeeDTO.Id);
            if (employeeDB is null)
            {
                throw new NotFoundException($"The employee with id {request.updateEmployeeDTO.Id} does not exist.");
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
