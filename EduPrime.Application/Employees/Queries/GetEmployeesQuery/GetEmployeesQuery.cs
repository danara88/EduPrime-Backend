using EduPrime.Core.DTOs.Employee;
using MediatR;

namespace EduPrime.Application.Employees.Queries
{
    /// <summary>
    /// Get employee query
    /// </summary>
    public record GetEmployeesQuery() : IRequest<List<EmployeeDTO>> { }
}
