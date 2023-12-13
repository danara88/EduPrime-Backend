using EduPrime.Application.Common.Interfaces;
using EduPrime.Application.Subjects.Interfaces;
using EduPrime.Core.Enums.Student;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Unassign subjects from a student command handler
    /// </summary>
    public class UnassignSubjectsCommandHandler : IRequestHandler<UnassignSubjectsCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISubjectService _subjectService;

        public UnassignSubjectsCommandHandler(IUnitOfWork unitOfWork, ISubjectService subjectService)
        {
            _unitOfWork = unitOfWork;
            _subjectService = subjectService;
        }

        public async Task<string> Handle(UnassignSubjectsCommand request, CancellationToken cancellationToken)
        {
            if (!(await _unitOfWork.StudentRepository.ExistsAnyStudent(request.unassignSubjectsDTO.StudentId)))
            {
                throw new NotFoundException($"The student with id {request.unassignSubjectsDTO.StudentId} does not exist.");
            }

            var student = await _unitOfWork.StudentRepository.GetStudentWithAssignmentsAsync(request.unassignSubjectsDTO.StudentId);

            // Unassign all subjects from the student
            if (request.unassignSubjectsDTO.UnassignAction == UnassignSubjectsActionEnum.All)
            {
                student.StudentsSubjects.Clear();
            }

            // Unassign certain subjects from the student
            if (request.unassignSubjectsDTO.UnassignAction == UnassignSubjectsActionEnum.NotAll)
            {
                if (request.unassignSubjectsDTO.SubjectIds.Any())
                {
                    request.unassignSubjectsDTO.SubjectIds = request.unassignSubjectsDTO.SubjectIds.Distinct().ToList();

                    var isValidSubjectsIds = await _subjectService.ValidateSubjectIds(request.unassignSubjectsDTO.SubjectIds, student);
                    if (!isValidSubjectsIds.Item1)
                    {
                        throw new BadRequestException(isValidSubjectsIds.Item2);
                    }

                    foreach (var subjectId in request.unassignSubjectsDTO.SubjectIds)
                    {
                        var studentSubject = student.StudentsSubjects.FirstOrDefault(ss => ss.SubjectId == subjectId);
                        if (studentSubject is not null)
                        {
                            student.StudentsSubjects.Remove(studentSubject);
                        }
                    }
                }
            }

            try
            {
                await _unitOfWork.SaveChangesAsync();
                return "The resource has been updated successfully";
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while updating the resource.");
            }
        }
    }
}
