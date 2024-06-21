using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Area;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Areas.Queries
{
    /// <summary>
    /// Get areas with employees query handler
    /// </summary>
    public class GetAreasWithEmployeesQueryHandler : IRequestHandler<GetAreasWithEmployeesQuery, ErrorOr<List<AreaWithEmployeesDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAreasWithEmployeesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper = null)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<List<AreaWithEmployeesDTO>>> Handle(GetAreasWithEmployeesQuery request, CancellationToken cancellationToken)
        {
            var areasWithEmployees = await _unitOfWork.AreaRepository.GetAreasWithEmployeesAsync();
            var areasWithEmployeesDTO = _mapper.Map<List<AreaWithEmployeesDTO>>(areasWithEmployees);

            return areasWithEmployeesDTO;
        }
    }
}
