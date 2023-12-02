using EduPrime.Core.DTOs.Employee;
using MediatR;

namespace EduPrime.Application.Employees.Queries
{
    /// <summary>
    /// Get employee by id query
    /// </summary>
    /// <param name="id"></param>
    public record GetEmployeeByIdQuery(int id) : IRequest<EmployeeDTO> { }
}
