using Application.DTOs;
using Domain.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exercises.Querries
{
    public class GetAllExercisesQuery : IRequest<OperationResult<List<ExerciseDto>>>;
}
