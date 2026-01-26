using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exercises.Commands
{
    public class DeleteExerciseCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
