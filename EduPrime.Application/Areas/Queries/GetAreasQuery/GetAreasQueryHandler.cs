using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Area;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Areas.Queries
{
    /// <summary>
    /// Get areas query handler
    /// </summary>
    public class GetAreasQueryHandler : IRequestHandler<GetAreasQuery, ErrorOr<List<AreaDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAreasQueryHandler(IUnitOfWork unitOfWork, IMapper mapper = null)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<List<AreaDTO>>> Handle(GetAreasQuery request, CancellationToken cancellationToken)
        {
            var areas = await _unitOfWork.AreaRepository.GetAllAsync();
            var areasDTO = _mapper.Map<List<AreaDTO>>(areas);

            return areasDTO;
        }
    }
}
