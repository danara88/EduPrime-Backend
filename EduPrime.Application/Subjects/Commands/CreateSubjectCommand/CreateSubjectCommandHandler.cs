using AutoMapper;
using ErrorOr;
using MediatR;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Application.Professors.Interfaces;
using EduPrime.Core.DTOs.Subject;
using EduPrime.Core.Entities;
using EduPrime.Core.Exceptions;
using EduPrime.Core.Professors;
using EduPrime.Core.Subjects;

namespace EduPrime.Application.Subjects.Commands
{
    /// <summary>
    /// Create subject command handler
    /// </summary>
    public class CreateSubjectCommandHandler : IRequestHandler<CreateSubjectCommand, ErrorOr<string>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IProfessorService _professorService;

        public CreateSubjectCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IProfessorService professorService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _professorService = professorService;
        }

        public async Task<ErrorOr<string>> Handle(CreateSubjectCommand request, CancellationToken cancellationToken)
        {
            if (await _unitOfWork.SubjectRepository.ExistsAnySubject(request.createSubjectDTO.Name))
            {
                return SubjectErrors.SubjectAlreadyExists(request.createSubjectDTO.Name);
            }

            var subject = _mapper.Map<Subject>(request.createSubjectDTO);

            if (request.createSubjectDTO.ProfessorIds is not null && request.createSubjectDTO.ProfessorIds.Any())
            {
                subject.ProfessorsSubjects = new List<ProfessorSubject>() { };
                request.createSubjectDTO.ProfessorIds = request.createSubjectDTO.ProfessorIds
                    .Distinct()
                    .ToList();

                if (request.createSubjectDTO.ProfessorIds.Count > 2)
                {
                    return SubjectErrors.SubjectCannotBeAssignedToMoreThanTwoProfessors;
                }

                var isValidProfessorIds = await _professorService.ValidProfessorIds(request.createSubjectDTO.ProfessorIds);

                if (!isValidProfessorIds.Item1)
                {
                    return ProfessorErrors.ProfessorWithIdDoesNotExist(isValidProfessorIds.Item2);
                }

                foreach (var professorId in request.createSubjectDTO.ProfessorIds)
                {
                    var professorSubject = new ProfessorSubject
                    {
                        SubjectId = subject.Id,
                        ProfessorId = professorId
                    };

                    subject.ProfessorsSubjects.Add(professorSubject);
                }
            }

            try
            {
                await _unitOfWork.SubjectRepository.AddAsync(subject);
                await _unitOfWork.SaveChangesAsync();

                var subjectDTO = _mapper.Map<SubjectDTO>(subject);
                return "The resource has been created successfully";
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while creating the resource.");
            }
        }
    }
}
