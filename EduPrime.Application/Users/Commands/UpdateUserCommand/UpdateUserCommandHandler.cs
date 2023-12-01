using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.User;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Update user command handler
    /// </summary>
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UserDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UserDTO> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var userDB = await _unitOfWork.UserRepository.GetByIdAsync(request.updateUserDTO.Id);
            if (userDB is null)
            {
                throw new NotFoundException($"The user with id {request.updateUserDTO.Id} does not exist.");
            }

            userDB = _mapper.Map(request.updateUserDTO, userDB);
            try
            {
                await _unitOfWork.SaveChangesAsync();
                var userDTO = _mapper.Map<UserDTO>(userDB);

                return userDTO;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while updating the resource.");
            }
        }
    }
}
