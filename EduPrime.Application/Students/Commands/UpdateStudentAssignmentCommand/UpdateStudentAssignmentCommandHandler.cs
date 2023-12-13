using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Students.Commands
{
    /// <summary>
    /// Update student subject assignment command handler
    /// </summary>
    public class UpdateStudentAssignmentCommandHandler : IRequestHandler<UpdateStudentAssignmentCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateStudentAssignmentCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(UpdateStudentAssignmentCommand request, CancellationToken cancellationToken)
        {
            var studentDB = await _unitOfWork.StudentRepository.GetStudentWithAssignmentsAsync(request.updateStudentAssignmentDTO.StudentId);
            var subjectDB = await _unitOfWork.SubjectRepository.GetByIdAsync(request.updateStudentAssignmentDTO.SubjectId);

            // Validate that the student exists
            if (studentDB is null)
            {
                throw new NotFoundException($"The student with id {request.updateStudentAssignmentDTO.StudentId} does not exist.");
            }

            // Validate that the subject exists
            if (subjectDB is null)
            {
                throw new NotFoundException($"The subject with id {request.updateStudentAssignmentDTO.SubjectId} does not exist.");
            }

            // Validate that the student is currently assigned to the subject
            var assignedSubjects = new List<Subject>();
            foreach (var studentSubject in studentDB.StudentsSubjects)
            {
                assignedSubjects.Add(studentSubject.Subject);
            }

            if (!assignedSubjects.Contains(subjectDB))
            {
                throw new BadRequestException($"The student with id {request.updateStudentAssignmentDTO.StudentId} is not assigned to the subject with id {subjectDB.Id}");
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
