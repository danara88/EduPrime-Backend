using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Area;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Areas.Queries
{
    /// <summary>
    /// Get area by id query handler
    /// </summary>
    public class GetAreaByIdQueryHandler : IRequestHandler<GetAreaByIdQuery, AreaDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAreaByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper = null)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<AreaDTO> Handle(GetAreaByIdQuery request, CancellationToken cancellationToken)
        {
            var area = await _unitOfWork.AreaRepository.GetByIdAsync(request.id);
            if (area is null)
            {
                throw new NotFoundException($"The area with id {request.id} does not exist.");
            }
            var areaDTO = _mapper.Map<AreaDTO>(area);

            return areaDTO;
        }
    }
}
