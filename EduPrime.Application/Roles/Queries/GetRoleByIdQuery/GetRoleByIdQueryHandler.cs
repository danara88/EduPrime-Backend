using AutoMapper;
using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Role;
using EduPrime.Core.Roles;

namespace EduPrime.Application.Roles.Queries
{
    /// <summary>
    /// Get role by id query hanlder
    /// </summary>
    public class GetRoleByIdQueryHandler : IRequestHandler<GetRoleByIdQuery, ErrorOr<RoleWithUsersDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetRoleByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper = null)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<RoleWithUsersDTO>> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
        {
            var role = await _unitOfWork.RoleRepository.GetByIdWithUsersAsync(request.Id);

            if (role is null)
            {
                return RoleErrors.RoleWithIdDoesNotExist(request.Id);
            }

            var roleWithUsersDTO = _mapper.Map<RoleWithUsersDTO>(role);

            return roleWithUsersDTO;
        }
    }
}
