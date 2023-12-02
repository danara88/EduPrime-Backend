using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Delete employee command handler
    /// </summary>
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteEmployeeCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employeeDB = await _unitOfWork.EmployeeRepository.GetByIdAsync(request.id);
            if (employeeDB is null)
            {
                throw new NotFoundException($"The employee with id {request.id} does not exist.");
            }

            try
            {
                await _unitOfWork.EmployeeRepository.Delete(employeeDB.Id);
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
