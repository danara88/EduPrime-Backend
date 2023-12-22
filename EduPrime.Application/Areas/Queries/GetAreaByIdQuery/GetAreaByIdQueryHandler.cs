using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Areas;
using EduPrime.Core.DTOs.Area;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Areas.Queries
{
    /// <summary>
    /// Get area by id query handler
    /// </summary>
    public class GetAreaByIdQueryHandler : IRequestHandler<GetAreaByIdQuery, ErrorOr<AreaDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAreaByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper = null)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<AreaDTO>> Handle(GetAreaByIdQuery request, CancellationToken cancellationToken)
        {
            var area = await _unitOfWork.AreaRepository.GetByIdAsync(request.id);
            if (area is null)
            {
                return AreaErrors.AreaWithIdDoesNotExist(request.id);
            }
            var areaDTO = _mapper.Map<AreaDTO>(area);

            return areaDTO;
        }
    }
}
