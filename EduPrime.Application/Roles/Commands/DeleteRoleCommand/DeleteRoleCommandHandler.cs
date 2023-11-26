using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Roles.Commands.DeleteRoleCommand
{
    /// <summary>
    /// Delete role command handler
    /// </summary>
    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteRoleCommandHandler(IUnitOfWork unitOfWork, IMapper mapper = null)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<string> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            var roleDB = await _unitOfWork.RoleRepository.GetByIdAsync(request.id);
            if (roleDB is null)
            {
                throw new NotFoundException($"The role with id {request.id} does not exist.");
            }

            try
            {
                await _unitOfWork.RoleRepository.Delete(roleDB.Id);
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
