using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Application.Professors.Interfaces;
using EduPrime.Core.Enums.Subject;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Subjects;
using EduPrime.Core.Professors;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Unassign professors from subject command handler
    /// </summary>
    public class UnassignProfessorsCommandHandler : IRequestHandler<UnassignProfessorsCommand, ErrorOr<string>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IProfessorService _professorService;

        public UnassignProfessorsCommandHandler(IUnitOfWork unitOfWork, IProfessorService professorService)
        {
            _unitOfWork = unitOfWork;
            _professorService = professorService;
        }

        public async Task<ErrorOr<string>> Handle(UnassignProfessorsCommand request, CancellationToken cancellationToken)
        {
            if (!await _unitOfWork.SubjectRepository.ExistsAnySubject(request.unassignProfessorsDTO.SubjectId))
            {
                return SubjectErrors.SubjectWithIdDoesNotExist(request.unassignProfessorsDTO.SubjectId);
            }

            var subject = await _unitOfWork.SubjectRepository.GetSubjectWithProfessorsAsync(request.unassignProfessorsDTO.SubjectId);

            // Unassign all professors from the subject
            if (request.unassignProfessorsDTO.UnassignAction == UnassignProfessorsActionEnum.All)
            {
                subject.ProfessorsSubjects.Clear();
            }

            // Unassign certain professors from the subject
            if (request.unassignProfessorsDTO.UnassignAction == UnassignProfessorsActionEnum.NotAll)
            {
                if (request.unassignProfessorsDTO.ProfessorIds.Any())
                {
                    request.unassignProfessorsDTO.ProfessorIds = request.unassignProfessorsDTO.ProfessorIds.Distinct().ToList();

                    if (request.unassignProfessorsDTO.ProfessorIds.Count() > 2)
                    {
                        return SubjectErrors.CannotUnassignMoreThanTwoProfessorsFromSubject;
                    }

                    var isValidProfessorIds = await _professorService.ValidProfessorIds(request.unassignProfessorsDTO.ProfessorIds);
                    if (!isValidProfessorIds.Item1)
                    {
                        return ProfessorErrors.ProfessorWithIdDoesNotExist(isValidProfessorIds.Item2);
                    }

                    foreach (var professorId in request.unassignProfessorsDTO.ProfessorIds)
                    {
                        var professorSubject = subject.ProfessorsSubjects.FirstOrDefault(ps => ps.ProfessorId == professorId);
                        if (professorSubject is not null)
                        {
                            subject.ProfessorsSubjects.Remove(professorSubject);
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
