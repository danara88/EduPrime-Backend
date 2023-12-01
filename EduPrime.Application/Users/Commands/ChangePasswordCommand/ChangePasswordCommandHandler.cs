using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using MediatR;
using Microsoft.AspNetCore.DataProtection;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Change password command handler
    /// </summary>
    public class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommand, string>
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

        public async Task<string> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            request.changePasswordDTO.Email = _dataProtector.Unprotect(request.changePasswordDTO.Email);

            var userDB = await _unitOfWork.UserRepository.GetUserByEmail(request.changePasswordDTO.Email);
            if (userDB is null)
            {
                throw new BadRequestException("Something went wrong while changing the password.");
            }

            // Validate password format
            if (!_passwordService.IsValidPassword(request.changePasswordDTO.Password))
            {
                throw new BadRequestException("Invalid password.");
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
