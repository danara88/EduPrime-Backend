using AutoMapper;
using EduPrime.Application.Common.Interfaces;
using EduPrime.Core.DTOs.Professor;
using EduPrime.Core.Exceptions;
using MediatR;

namespace EduPrime.Application.Professors.Commands
{
    /// <summary>
    /// Update professor command handler
    /// </summary>
    public class UpdateProfessorCommandHandler : IRequestHandler<UpdateProfessorCommand, ProfessorDTO>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateProfessorCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ProfessorDTO> Handle(UpdateProfessorCommand request, CancellationToken cancellationToken)
        {
            var professorDB = await _unitOfWork.ProfessorRepository.GetByIdAsync(request.updateProfessorDTO.Id);
            if (professorDB is null)
            {
                throw new NotFoundException($"The professor with id {request.updateProfessorDTO.Id} does not exist.");
            }

            professorDB = _mapper.Map(request.updateProfessorDTO, professorDB);
            try
            {
                await _unitOfWork.SaveChangesAsync();
                var professorDTO = _mapper.Map<ProfessorDTO>(professorDB);

                return professorDTO;
            }
            catch (Exception)
            {
                throw new InternalServerException("Something went wrong while updating the resource.");
            }
        }
    }
}
