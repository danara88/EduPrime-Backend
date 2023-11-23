using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Areas.Commands
{
    /// <summary>
    /// Delete area command handler
    /// </summary>
    public class DeleteAreaCommandHandler : IRequestHandler<DeleteAreaCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DeleteAreaCommandHandler(IUnitOfWork unitOfWork, IMapper mapper = null)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<string> Handle(DeleteAreaCommand request, CancellationToken cancellationToken)
        {
            var areaDB = await _unitOfWork.AreaRepository.GetByIdAsync(request.id);
            if (areaDB is null)
            {
                throw new NotFoundException($"The area with id {request.id} does not exist.");
            }

            try
            {
                await _unitOfWork.AreaRepository.Delete(areaDB.Id);
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
