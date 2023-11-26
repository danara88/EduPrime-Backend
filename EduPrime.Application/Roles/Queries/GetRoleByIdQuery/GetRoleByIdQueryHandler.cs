using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Role;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Roles.Queries
{
    /// <summary>
    /// Get role by id query hanlder
    /// </summary>
    public class GetRoleByIdQueryHandler : IRequestHandler<GetRoleByIdQuery, RoleWithUsersDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetRoleByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper = null)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<RoleWithUsersDTO> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
        {
            var role = await _unitOfWork.RoleRepository.GetByIdWithUsersAsync(request.Id);

            if (role is null)
            {
                throw new NotFoundException($"The role with id {request.Id} does not exist.");
            }

            var roleWithUsersDTO = _mapper.Map<RoleWithUsersDTO>(role);

            return roleWithUsersDTO;
        }
    }
}
