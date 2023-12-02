using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Employee;
using MediatR;

namespace EduPrime.Application.Employees.Queries
{
    /// <summary>
    /// Get employees query handler
    /// </summary>
    public class GetEmployeeQueryHandler : IRequestHandler<GetEmployeesQuery, List<EmployeeDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetEmployeeQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<EmployeeDTO>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = await _unitOfWork.EmployeeRepository.GetAllAsync();
            var employeesDTO = _mapper.Map<List<EmployeeDTO>>(employees);

            return employeesDTO;
        }
    }
}
