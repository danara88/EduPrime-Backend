using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Student;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Students.Queries
{
    /// <summary>
    /// Get student by id query handler
    /// </summary>
    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, StudentDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetStudentByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<StudentDTO> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _unitOfWork.StudentRepository.GetStudentWithAssignmentsAsync(request.id);
            if (student is null)
            {
                throw new NotFoundException($"The student with id {request.id} does not exist.");
            }

            var studentDTO = _mapper.Map<StudentDTO>(student);

            return studentDTO;
        }
    }
}
