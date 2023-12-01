using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.User;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Login command handler
    /// </summary>
    public class LoginCommandHandler : IRequestHandler<LoginCommand, AuthTokenDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPasswordService _passwordService;
        private readonly IJwtFactory _jwtFactory;

        public LoginCommandHandler(IUnitOfWork unitOfWork, IPasswordService passwordService, IJwtFactory jwtFactory)
        {
            _unitOfWork = unitOfWork;
            _passwordService = passwordService;
            _jwtFactory = jwtFactory;
        }

        public async Task<AuthTokenDTO> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var emailExists = await _unitOfWork.UserRepository.UserEmailExistsAsync(request.logInUserDTO.Email);
            if (!emailExists)
            {
                throw new BadRequestException("The email or password are invalid.");
            }

            var user = await _unitOfWork.UserRepository.GetUserByEmail(request.logInUserDTO.Email);

            var validPassword = _passwordService.CheckHash(user.Password,request.logInUserDTO.Password);
            if (!validPassword)
            {
                throw new BadRequestException("The email or password are invalid.");
            }

            if (!user.EmailConfirmed)
            {
                throw new BadRequestException("The email needs to be confirmed.");
            }
            user.LastLogin = DateTime.UtcNow;

            try
            {
                await _unitOfWork.SaveChangesAsync();
                AuthTokenDTO authTokenDTO = new()
                {
                    AccessToken = _jwtFactory.GenerateJwtToken(user)
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
