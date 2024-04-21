using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Application.Subjects.Interfaces;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Students;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Assign subjects to student command handler
    /// </summary>
    public class AssignSubjectsCommandHandler : IRequestHandler<AssignSubjectsCommand, ErrorOr<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISubjectService _subjectService;

        public AssignSubjectsCommandHandler(IUnitOfWork unitOfWork, ISubjectService subjectService)
        {
            _unitOfWork = unitOfWork;
            _subjectService = subjectService;
        }

        public async Task<ErrorOr<string>> Handle(AssignSubjectsCommand request, CancellationToken cancellationToken)
        {
            if (!await _unitOfWork.StudentRepository.ExistsAnyStudent(request.assignSubjectsDTO.StudentId))
            {
                return StudentErrors.StudentWithIdDoesNotExist(request.assignSubjectsDTO.StudentId);
            }

            if (request.assignSubjectsDTO.SubjectIds.Count() == 0)
            {
                return StudentErrors.StudentRequiresAtLeastOneSubject;
            }
            request.assignSubjectsDTO.SubjectIds = request.assignSubjectsDTO.SubjectIds.Distinct().ToList();

            var student = await _unitOfWork.StudentRepository.GetStudentWithAssignmentsAsync(request.assignSubjectsDTO.StudentId);

            var isValidSubjectIds = await _subjectService.ValidateSubjectIds(request.assignSubjectsDTO.SubjectIds, student);
            if (!isValidSubjectIds.Item1)
            {
                // Return the correct error
                return isValidSubjectIds.Item2;
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
