using AutoMapper;
using MediatR;
using ErrorOr;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Student;
using EduPrime.Core.Students;

namespace EduPrime.Application.Students.Queries
{
    /// <summary>
    /// Get student by id query handler
    /// </summary>
    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, ErrorOr<StudentDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetStudentByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<StudentDTO>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _unitOfWork.StudentRepository.GetStudentWithAssignmentsAsync(request.id);
            if (student is null)
            {
                return StudentErrors.StudentWithIdDoesNotExist(request.id);
            }

            var studentDTO = _mapper.Map<StudentDTO>(student);

            return studentDTO;
        }
    }
}
