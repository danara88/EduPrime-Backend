using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Role;
using MediatR;

namespace EduPrime.Application.Roles.Queries
{
    /// <summary>
    /// Get roles query handler
    /// </summary>
    public class GetRolesQueryHandler : IRequestHandler<GetRolesQuery, List<RoleDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetRolesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper = null)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<RoleDTO>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
        {
            var roles = await _unitOfWork.RoleRepository.GetAllAsync();
            var rolesDTO = _mapper.Map<List<RoleDTO>>(roles);

            return rolesDTO;
        }
    }
}
