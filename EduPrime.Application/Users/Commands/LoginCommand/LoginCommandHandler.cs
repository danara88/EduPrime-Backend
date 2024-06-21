using ErrorOr;
using MediatR;
using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.User;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Users;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Login command handler
    /// </summary>
    public class LoginCommandHandler : IRequestHandler<LoginCommand, ErrorOr<AuthTokenDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPasswordService _passwordService;
        private readonly IJwtFactory _jwtFactory;
        private readonly IMapper _mapper;

        public LoginCommandHandler(
            IUnitOfWork unitOfWork,
            IPasswordService passwordService,
            IJwtFactory jwtFactory,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _passwordService = passwordService;
            _jwtFactory = jwtFactory;
            _mapper = mapper;
        }

        public async Task<ErrorOr<AuthTokenDTO>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var emailExists = await _unitOfWork.UserRepository.UserEmailExistsAsync(request.logInUserDTO.Email);
            if (!emailExists)
            {
                return UserErrors.InvalidUserCredentials;
            }

            var user = await _unitOfWork.UserRepository.GetUserByEmail(request.logInUserDTO.Email);

            var validPassword = _passwordService.CheckHash(user.Password,request.logInUserDTO.Password);
            if (!validPassword)
            {
                return UserErrors.InvalidUserCredentials;
            }

            if (!user.EmailConfirmed)
            {
                return UserErrors.UserEmailMustBeConfirmed;
            }

            user.LastLogin = DateTime.UtcNow;

            var userDTO = _mapper.Map<UserDTO>(user);

            try
            {
                await _unitOfWork.SaveChangesAsync();
                AuthTokenDTO authTokenDTO = new()
                {
                    AccessToken = _jwtFactory.GenerateJwtToken(userDTO)
                };
                return authTokenDTO;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while log in user.");
            }
        }
    }
}
