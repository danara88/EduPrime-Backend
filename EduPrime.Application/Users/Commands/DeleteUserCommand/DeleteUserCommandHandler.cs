using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Users;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Delete user command handler
    /// </summary>
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, ErrorOr<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteUserCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ErrorOr<string>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var userDB = await _unitOfWork.UserRepository.GetByIdAsync(request.id);
            if (userDB is null)
            {
                return UserErrors.UserWithIdDoesNotExist(request.id);
            }

            try
            {
                await _unitOfWork.UserRepository.Delete(userDB.Id);
                await _unitOfWork.SaveChangesAsync();

                return "The resource has been deleted successfully";
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while deleting the resource.");
            }
        }
    }
}
