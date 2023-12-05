using EduPrime.Application.Common.Interfaces;
using EduPrime.Application.Professors.Interfaces;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Assign professors to subject command handler
    /// </summary>
    public class AssignProfessorsCommandHandler : IRequestHandler<AssignProfessorsCommand, string>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProfessorService _professorService;

        public AssignProfessorsCommandHandler(IUnitOfWork unitOfWork, IProfessorService professorService)
        {
            _unitOfWork = unitOfWork;
            _professorService = professorService;
        }

        public async Task<string> Handle(AssignProfessorsCommand request, CancellationToken cancellationToken)
        {
            if (!await _unitOfWork.SubjectRepository.ExistsAnySubject(request.assignProfessorsDTO.SubjectId))
            {
                throw new NotFoundException($"The subject with id {request.assignProfessorsDTO.SubjectId} does not exist.");
            }

            if (request.assignProfessorsDTO.ProfessorIds.Count() == 0)
            {
                throw new BadRequestException("Please assign at least 1 professor.");
            }

            request.assignProfessorsDTO.ProfessorIds = request.assignProfessorsDTO.ProfessorIds.Distinct().ToList();
            if (request.assignProfessorsDTO.ProfessorIds.Count() > 2)
            {
                throw new BadRequestException($"You can only assign maximum 2 professors per subject.");
            }

            var isValidProfessorIds = await _professorService.ValidProfessorIds(request.assignProfessorsDTO.ProfessorIds);
            if (!isValidProfessorIds.Item1)
            {
                throw new NotFoundException($"The professor with id {isValidProfessorIds.Item2} does not exist.");
            }

            var subject = await _unitOfWork.SubjectRepository.GetSubjectWithProfessorsAsync(request.assignProfessorsDTO.SubjectId);

            switch (subject.ProfessorsSubjects.Count())
            {
                case 2:
                    throw new BadRequestException($"The subject with id {request.assignProfessorsDTO.SubjectId} is already assigned to 2 professors. Please unassign professors to continue.");
                case 1:
                    if (request.assignProfessorsDTO.ProfessorIds.Count() > 1)
                    {
                        throw new BadRequestException($"You are trying to add more than 1 professor. The subject with id {request.assignProfessorsDTO.SubjectId} is already assigned to 1 professor.");
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
