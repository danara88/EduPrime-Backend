using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Area;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Areas.Commands
{
    /// <summary>
    /// Update area command handler
    /// </summary>
    public class UpdateAreaCommandHandler : IRequestHandler<UpdateAreaCommand, AreaDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateAreaCommandHandler(IUnitOfWork unitOfWork, IMapper mapper = null)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<AreaDTO> Handle(UpdateAreaCommand request, CancellationToken cancellationToken)
        {
            var areaDB = await _unitOfWork.AreaRepository.GetByIdAsync(request.updateAreaDTO.Id);
            if (areaDB is null)
            {
                throw new NotFoundException($"The area with id {request.updateAreaDTO.Id} does not exist.");
            }

            areaDB = _mapper.Map(request.updateAreaDTO, areaDB);
            try
            {
                await _unitOfWork.SaveChangesAsync();
                var areaDTO = _mapper.Map<AreaDTO>(areaDB);

                return areaDTO;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while updating the resource.");
            }
        }
    }
}
