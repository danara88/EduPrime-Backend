using AutoMapper;
using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.User;
using EduPrime.Core.Users;

namespace EduPrime.Application.Users.Queries
{
    /// <summary>
    /// Get user by id query handler
    /// </summary>
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, ErrorOr<UserDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetUserByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<UserDTO>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.UserRepository.GetByIdWithAssignedRoleAsync(request.id);
            if (user is null)
            {
                return UserErrors.UserWithIdDoesNotExist(request.id);
            }

            var userDTO = _mapper.Map<UserDTO>(user);

            return userDTO;
        }
    }
}
