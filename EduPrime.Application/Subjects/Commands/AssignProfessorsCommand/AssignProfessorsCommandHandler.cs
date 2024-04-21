using MediatR;
using ErrorOr;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Application.Professors.Interfaces;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Subjects;
using EduPrime.Core.Professors;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Assign professors to subject command handler
    /// </summary>
    public class AssignProfessorsCommandHandler : IRequestHandler<AssignProfessorsCommand, ErrorOr<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProfessorService _professorService;

        public AssignProfessorsCommandHandler(IUnitOfWork unitOfWork, IProfessorService professorService)
        {
            _unitOfWork = unitOfWork;
            _professorService = professorService;
        }

        public async Task<ErrorOr<string>> Handle(AssignProfessorsCommand request, CancellationToken cancellationToken)
        {
            if (!await _unitOfWork.SubjectRepository.ExistsAnySubject(request.assignProfessorsDTO.SubjectId))
            {
                return SubjectErrors.SubjectWithIdDoesNotExist(request.assignProfessorsDTO.SubjectId);
            }

            if (request.assignProfessorsDTO.ProfessorIds.Count() == 0)
            {
                return SubjectErrors.SubjectRequiresAtLeastOneProfessor;
            }

            request.assignProfessorsDTO.ProfessorIds = request.assignProfessorsDTO.ProfessorIds.Distinct().ToList();
            if (request.assignProfessorsDTO.ProfessorIds.Count() > 2)
            {
                return SubjectErrors.SubjectCannotBeAssignedToMoreThanTwoProfessors;
            }

            var isValidProfessorIds = await _professorService.ValidProfessorIds(request.assignProfessorsDTO.ProfessorIds);
            if (!isValidProfessorIds.Item1)
            {
                return ProfessorErrors.ProfessorWithIdDoesNotExist(isValidProfessorIds.Item2);
            }

            var subject = await _unitOfWork.SubjectRepository.GetSubjectWithProfessorsAsync(request.assignProfessorsDTO.SubjectId);

            switch (subject.ProfessorsSubjects.Count())
            {
                case 2:
                    return SubjectErrors.SubjectAlreadyAddedToTwoProfessors(request.assignProfessorsDTO.SubjectId);
                case 1:
                    if (request.assignProfessorsDTO.ProfessorIds.Count() > 1)
                    {
                        return SubjectErrors.CannotAddMoreThanOneProfessorToSubject(request.assignProfessorsDTO.SubjectId);
                    }
                    break;
            }

            foreach (var professorId in request.assignProfessorsDTO.ProfessorIds)
            {
                var professorSubject = new ProfessorSubject
                {
                    SubjectId = subject.Id,
                    ProfessorId = professorId
                };

                subject.ProfessorsSubjects.Add(professorSubject);
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
