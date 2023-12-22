using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Areas;
using EduPrime.Core.DTOs.Area;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Areas.Commands
{
    /// <summary>
    /// Create area command handler
    /// </summary>
    public class CreateAreaCommandHandler : IRequestHandler<CreateAreaCommand, ErrorOr<AreaDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateAreaCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<AreaDTO>> Handle(CreateAreaCommand request, CancellationToken cancellationToken)
        {
            if (await _unitOfWork.AreaRepository.ExistsAnyArea(request.createAreaDTO.Name))
            {
                return AreaErrors.AreaWithNameAlreadyExists(request.createAreaDTO.Name);
            }

            var area = _mapper.Map<Area>(request.createAreaDTO);
            try
            {
                await _unitOfWork.AreaRepository.AddAsync(area);
                await _unitOfWork.SaveChangesAsync();
                var areaDTO = _mapper.Map<AreaDTO>(area);

                return areaDTO;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while creating the resource.");
            }
        }
    }
}
