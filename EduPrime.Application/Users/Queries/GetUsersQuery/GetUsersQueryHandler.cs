using AutoMapper;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.User;
using ErrorOr;

namespace EduPrime.Application.Users.Queries
{
    /// <summary>
    /// Get usera query handler
    /// </summary>
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, ErrorOr<List<UserDTO>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetUsersQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<List<UserDTO>>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _unitOfWork.UserRepository.GetAllAsync();
            var usersDTO = _mapper.Map<List<UserDTO>>(users);

            return usersDTO;
        }
    }
}
