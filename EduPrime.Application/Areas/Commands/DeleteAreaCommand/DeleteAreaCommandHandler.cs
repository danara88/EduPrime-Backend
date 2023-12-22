using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Areas;
using EduPrime.Core.Exceptions;
using ErrorOr;
using MediatR;

namespace EduPrime.Application.Areas.Commands
{
    /// <summary>
    /// Delete area command handler
    /// </summary>
    public class DeleteAreaCommandHandler : IRequestHandler<DeleteAreaCommand, ErrorOr<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteAreaCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ErrorOr<string>> Handle(DeleteAreaCommand request, CancellationToken cancellationToken)
        {
            var areaDB = await _unitOfWork.AreaRepository.GetByIdAsync(request.id);
            if (areaDB is null)
            {
                return AreaErrors.AreaWithIdDoesNotExist(request.id);
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
