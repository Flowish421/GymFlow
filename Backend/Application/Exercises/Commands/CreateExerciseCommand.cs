using Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exercises.Commands
{
    public class CreateExerciseCommand : IRequest<ExerciseDto>
    {
        public required string Name { get; set; }
    }
}
