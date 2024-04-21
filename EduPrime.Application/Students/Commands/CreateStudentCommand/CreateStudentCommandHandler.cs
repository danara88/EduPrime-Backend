using AutoMapper;
using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Student;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Create student command handler
    /// </summary>
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, ErrorOr<StudentDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateStudentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<StudentDTO>> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = _mapper.Map<Student>(request.createStudentDTO);

            try
            {
                await _unitOfWork.StudentRepository.AddAsync(student);
                await _unitOfWork.SaveChangesAsync();

                var studentDTO = _mapper.Map<StudentDTO>(student);
                return studentDTO;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while creating the resource.");
            }
        }
    }
}
