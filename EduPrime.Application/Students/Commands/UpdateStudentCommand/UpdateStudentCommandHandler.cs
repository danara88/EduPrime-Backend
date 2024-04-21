using AutoMapper;
using ErrorOr;
using MediatR;
using EduPrime.Core.Exceptions;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Student;
using EduPrime.Core.Students;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Update student command handler
    /// </summary>
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, ErrorOr<StudentDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateStudentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ErrorOr<StudentDTO>> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var studentDB = await _unitOfWork.StudentRepository.GetByIdAsync(request.updateStudentDTO.Id);
            if (studentDB is null)
            {
                return StudentErrors.StudentWithIdDoesNotExist(request.updateStudentDTO.Id);
            }

            request.updateStudentDTO.Id = studentDB.Id;
            studentDB = _mapper.Map(request.updateStudentDTO, studentDB);

            try
            {
                await _unitOfWork.SaveChangesAsync();
                var studentDTO = _mapper.Map<StudentDTO>(studentDB);

                return studentDTO;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while updating the resource.");
            }
        }
    }
}
