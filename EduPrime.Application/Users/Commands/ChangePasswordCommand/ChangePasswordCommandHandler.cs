using ErrorOr;
using MediatR;
using Microsoft.AspNetCore.DataProtection;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Users;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Change password command handler
    /// </summary>
    public class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommand, ErrorOr<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDataProtector _dataProtector;
        private readonly IPasswordService _passwordService;

        public ChangePasswordCommandHandler(
            IDataProtectionProvider dataProtectionProvider,
            IUnitOfWork unitOfWork,
            IPasswordService passwordService)
        {
            _dataProtector = dataProtectionProvider.CreateProtector("RecoveryPasswordEmail");
            _unitOfWork = unitOfWork;
            _passwordService = passwordService;
        }

        public async Task<ErrorOr<string>> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            request.changePasswordDTO.Email = _dataProtector.Unprotect(request.changePasswordDTO.Email);

            var userDB = await _unitOfWork.UserRepository.GetUserByEmail(request.changePasswordDTO.Email);
            if (userDB is null)
            {
                return UserErrors.UserEmailDoesNotExist;
            }

            // Validate password format
            // TODO: Change method name IsValidPassword to IsValidPasswordFormat
            if (!_passwordService.IsValidPassword(request.changePasswordDTO.Password))
            {
                return UserErrors.InvalidPasswordFormat;
            }

            // Hash new inserted password and assign to the user
            userDB.Password = _passwordService.HashPassword(request.changePasswordDTO.Password);

            try
            {
                await _unitOfWork.SaveChangesAsync();
                return "The password has been updated successfully";
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while changing the password.");
            }
        }
    }
}
