using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exercises.Commands
{
    public class UpdateExerciseCommandHandler : IRequestHandler<UpdateExerciseCommand, ExerciseDto>
    {
        private readonly IExerciseRepository _exerciseRepository;
        private readonly IMapper _mapper;

        public UpdateExerciseCommandHandler(IExerciseRepository exerciseRepository, IMapper mapper)
        {
            _exerciseRepository = exerciseRepository;
            _mapper = mapper;
        }

        public async Task<ExerciseDto> Handle(UpdateExerciseCommand request, CancellationToken cancellationToken)
        {
            var exercise = await _exerciseRepository.GetExerciseByIdAsync(request.Id);

            if (exercise == null)
                throw new KeyNotFoundException($"Exercise with Id {request.Id} does not exist");

            exercise.Name = request.Name;

            await _exerciseRepository.UpdateExerciseAsync(exercise);

            return _mapper.Map<ExerciseDto>(exercise);
        }
    }
}
