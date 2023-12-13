using EduPrime.Application.Common.Interfaces;
using EduPrime.Application.Subjects.Interfaces;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Assign subjects to student command handler
    /// </summary>
    public class AssignSubjectsCommandHandler : IRequestHandler<AssignSubjectsCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISubjectService _subjectService;

        public AssignSubjectsCommandHandler(IUnitOfWork unitOfWork, ISubjectService subjectService)
        {
            _unitOfWork = unitOfWork;
            _subjectService = subjectService;
        }

        public async Task<string> Handle(AssignSubjectsCommand request, CancellationToken cancellationToken)
        {
            if (!(await _unitOfWork.StudentRepository.ExistsAnyStudent(request.assignSubjectsDTO.StudentId)))
            {
                throw new NotFoundException($"The student with id {request.assignSubjectsDTO.StudentId} does not exist.");
            }

            if (request.assignSubjectsDTO.SubjectIds.Count() == 0)
            {
                throw new BadRequestException("Please assign at least 1 subject.");
            }
            request.assignSubjectsDTO.SubjectIds = request.assignSubjectsDTO.SubjectIds.Distinct().ToList();

            var student = await _unitOfWork.StudentRepository.GetStudentWithAssignmentsAsync(request.assignSubjectsDTO.StudentId);

            var isValidSubjectIds = await _subjectService.ValidateSubjectIds(request.assignSubjectsDTO.SubjectIds, student);
            if (!isValidSubjectIds.Item1)
            {
                throw new BadRequestException(isValidSubjectIds.Item2);
            }

            foreach (var subjectId in request.assignSubjectsDTO.SubjectIds)
            {
                var studentSubject = new StudentSubject
                {
                    StudentId = student.Id,
                    SubjectId = subjectId
                };

                student.StudentsSubjects.Add(studentSubject);
            }

            try
            {
                await _unitOfWork.SaveChangesAsync();
                return "The resource has been updated successfully";
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while creating the resource.");
            }
        }
    }
}
