using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.User;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Roles.Commands
{
    /// <summary>
    /// Update user role command handler
    /// </summary>
    public class UpdateUserRoleCommandHandler : IRequestHandler<UpdateUserRoleCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateUserRoleCommandHandler(IUnitOfWork unitOfWork, IMapper mapper = null)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<string> Handle(UpdateUserRoleCommand request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.UserRepository.GetByIdWithAssignedRoleAsync(request.updateUserRoleDTO.UserId);

            // Validates if the user exist
            if (user is null)
            {
                throw new NotFoundException($"The user with id {request.updateUserRoleDTO.UserId} does not exist.");
            }

            // Validates if the role exist
            if (!(await _unitOfWork.RoleRepository.ExistsAnyRoleAsync(request.updateUserRoleDTO.RoleId)))
            {
                throw new NotFoundException($"The role with id {request.updateUserRoleDTO.RoleId} does not exist.");
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
