using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Students;
using EduPrime.Core.Subjects;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Update student subject assignment command handler
    /// </summary>
    public class UpdateStudentAssignmentCommandHandler : IRequestHandler<UpdateStudentAssignmentCommand, ErrorOr<string>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateStudentAssignmentCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ErrorOr<string>> Handle(UpdateStudentAssignmentCommand request, CancellationToken cancellationToken)
        {
            var studentDB = await _unitOfWork.StudentRepository.GetStudentWithAssignmentsAsync(request.updateStudentAssignmentDTO.StudentId);
            var subjectDB = await _unitOfWork.SubjectRepository.GetByIdAsync(request.updateStudentAssignmentDTO.SubjectId);

            // Validate that the student exists
            if (studentDB is null)
            {
                return StudentErrors.StudentWithIdDoesNotExist(request.updateStudentAssignmentDTO.StudentId);
            }

            // Validate that the subject exists
            if (subjectDB is null)
            {
                return SubjectErrors.SubjectWithIdDoesNotExist(request.updateStudentAssignmentDTO.SubjectId);
            }

            // Validate that the student is currently assigned to the subject
            var assignedSubjects = new List<Subject>();
            foreach (var studentSubject in studentDB.StudentsSubjects)
            {
                assignedSubjects.Add(studentSubject.Subject);
            }

            if (!assignedSubjects.Contains(subjectDB))
            {
                return StudentErrors.StudentIsNotAssignedToSubject(subjectDB.Id);
            }

            var studentSubjectToUpdate = studentDB.StudentsSubjects.First(ss => ss.SubjectId == subjectDB.Id);
            studentSubjectToUpdate.FirstGrade = request.updateStudentAssignmentDTO.FirstGrade;
            studentSubjectToUpdate.SecondGrade = request.updateStudentAssignmentDTO.SecondGrade;
            studentSubjectToUpdate.FinalGrade = request.updateStudentAssignmentDTO.FinalGrade;
            studentSubjectToUpdate.Status = request.updateStudentAssignmentDTO.Status;

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
