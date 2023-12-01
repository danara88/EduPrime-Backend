using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Confirm email command handler
    /// </summary>
    public class ConfirmEmailCommandHandler : IRequestHandler<ConfirmEmailCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ConfirmEmailCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(ConfirmEmailCommand request, CancellationToken cancellationToken)
        {
            var userDB = await _unitOfWork.UserRepository.GetByVerificationTokenAsync(request.confirmEmailDTO.Code);

            // Validates if the verificationToken exists and is assigned to the correct user
            if (userDB is null)
            {
                throw new BadRequestException($"The verification token is invalid.");
            }

            // Validates if the user has not previously confirmed the account
            if (userDB.EmailConfirmed)
            {
                throw new BadRequestException($"The email is already confirmed.");
            }

            // Validates if the verification token is not yet expired
            if (DateTime.UtcNow > userDB.VerificationTokenExpirationTime)
            {
                throw new BadRequestException($"The verification token has expired.");
            }

            userDB.EmailConfirmed = true;
            userDB.VerifiedAt = DateTime.UtcNow;

            try
            {
                await _unitOfWork.SaveChangesAsync();
                return "Your account has been confirmed.";
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while verifying the email.");
            }
        }
    }
}
