using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Role;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Roles.Commands
{
    /// <summary>
    /// Create role command handlr
    /// </summary>
    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, RoleDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateRoleCommandHandler(IUnitOfWork unitOfWork, IMapper mapper = null)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<RoleDTO> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            if (await _unitOfWork.RoleRepository.ExistsAnyRoleAsync(request.createRoleDTO.Name))
            {
                throw new BadRequestException($"The role with name {request.createRoleDTO.Name} already exists.");
            }

            var role = _mapper.Map<Role>(request.createRoleDTO);
            try
            {
                await _unitOfWork.RoleRepository.AddAsync(role);
                await _unitOfWork.SaveChangesAsync();
                var roleDTO = _mapper.Map<RoleDTO>(role);

                return roleDTO;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while creating the resource.");
            }
        }
    }
}
