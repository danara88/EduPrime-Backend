using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.User;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Users.Queries
{
    /// <summary>
    /// Get user by id query handler
    /// </summary>
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetUserByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UserDTO> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.UserRepository.GetByIdWithAssignedRoleAsync(request.id);
            if (user is null)
            {
                throw new NotFoundException($"The user with id {request.id} does not exist.");
            }

            var userDTO = _mapper.Map<UserDTO>(user);

            return userDTO;
        }
    }
}
