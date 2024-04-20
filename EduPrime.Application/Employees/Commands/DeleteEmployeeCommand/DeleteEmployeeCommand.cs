using ErrorOr;
using MediatR;

namespace EduPrime.Application.Employees.Commands
{
    /// <summary>
    /// Delete employee command
    /// </summary>
    public record DeleteEmployeeCommand(int id) : IRequest<ErrorOr<string>> { }
}
