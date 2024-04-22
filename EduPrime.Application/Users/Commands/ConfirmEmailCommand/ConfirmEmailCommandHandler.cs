using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Users;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Confirm email command handler
    /// </summary>
    public class ConfirmEmailCommandHandler : IRequestHandler<ConfirmEmailCommand, ErrorOr<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ConfirmEmailCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ErrorOr<string>> Handle(ConfirmEmailCommand request, CancellationToken cancellationToken)
        {
            var userDB = await _unitOfWork.UserRepository.GetByVerificationTokenAsync(request.confirmEmailDTO.Code);

            // Validates if the verificationToken exists and is assigned to the correct user
            if (userDB is null)
            {
                return UserErrors.InvalidVerificationToken;
            }

            // Validates if the user has not previously confirmed the account
            if (userDB.EmailConfirmed)
            {
               return UserErrors.UserEmailAlreadyConfirmed;
            }

            // Validates if the verification token is not yet expired
            if (DateTime.UtcNow > userDB.VerificationTokenExpirationTime)
            {
                return UserErrors.ExpiredVerificationToken;
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
