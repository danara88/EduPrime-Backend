using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Users.Commands
{
    /// <summary>
    /// Delete user command handler
    /// </summary>
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteUserCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var userDB = await _unitOfWork.UserRepository.GetByIdAsync(request.id);
            if (userDB is null)
            {
                throw new NotFoundException($"The user with id {request.id} does not exist.");
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
