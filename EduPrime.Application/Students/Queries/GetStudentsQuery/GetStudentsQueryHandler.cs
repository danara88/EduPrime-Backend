using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Student;
using MediatR;

namespace EduPrime.Application.Students.Queries
{
    /// <summary>
    /// Get students query handler
    /// </summary>
    public class GetStudentsQueryHandler : IRequestHandler<GetStudentsQuery, List<StudentDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetStudentsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<StudentDTO>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            var students = (await _unitOfWork.StudentRepository.GetStudentsWithAssignmentsAsync())
            .Skip((request.paginationDTO.CurrentPage - 1) * request.paginationDTO.QuantityPerPage)
            .Take(request.paginationDTO.QuantityPerPage)
                .ToList();
            var studentsDTO = _mapper.Map<List<StudentDTO>>(students);
            
            return studentsDTO;
        }
    }
}
