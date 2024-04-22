using ErrorOr;
using MediatR;
using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Roles;

namespace EduPrime.Application.Roles.Commands.DeleteRoleCommand
{
    /// <summary>
    /// Delete role command handler
    /// </summary>
    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand, ErrorOr<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteRoleCommandHandler(IUnitOfWork unitOfWork, IMapper mapper = null)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<string>> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            var roleDB = await _unitOfWork.RoleRepository.GetByIdAsync(request.id);
            if (roleDB is null)
            {
                return RoleErrors.RoleWithIdDoesNotExist(request.id);
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
