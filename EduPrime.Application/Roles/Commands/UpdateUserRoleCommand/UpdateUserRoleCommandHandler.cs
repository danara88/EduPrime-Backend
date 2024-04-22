using AutoMapper;
using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.User;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Users;
using EduPrime.Core.Roles;

namespace EduPrime.Application.Roles.Commands
{
    /// <summary>
    /// Update user role command handler
    /// </summary>
    public class UpdateUserRoleCommandHandler : IRequestHandler<UpdateUserRoleCommand, ErrorOr<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateUserRoleCommandHandler(IUnitOfWork unitOfWork, IMapper mapper = null)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<string>> Handle(UpdateUserRoleCommand request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.UserRepository.GetByIdWithAssignedRoleAsync(request.updateUserRoleDTO.UserId);

            // Validates if the user exist
            if (user is null)
            {
                return UserErrors.UserWithIdDoesNotExist(request.updateUserRoleDTO.UserId);
            }

            // Validates if the role exist
            if (!await _unitOfWork.RoleRepository.ExistsAnyRoleAsync(request.updateUserRoleDTO.RoleId))
            {
                return RoleErrors.RoleWithIdDoesNotExist(request.updateUserRoleDTO.RoleId);
            }

            user.RoleId = request.updateUserRoleDTO.RoleId;

            try
            {
                await _unitOfWork.SaveChangesAsync();
                var userDTO = _mapper.Map<UserDTO>(user);

                return "The resource has been updated successfully";
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while updating the resource.");
            }
        }
    }
}
