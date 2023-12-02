using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Employee;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Employees.Queries
{
    /// <summary>
    /// Get employee by id query handler
    /// </summary>
    public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, EmployeeDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetEmployeeByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<EmployeeDTO> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employee = await _unitOfWork.EmployeeRepository.GetByIdAsync(request.id);
            if (employee is null)
            {
                throw new NotFoundException($"The employee with id {request.id} does not exist.");
            }

            var employeeDTO = _mapper.Map<EmployeeDTO>(employee);

            return employeeDTO;
        }
    }
}
