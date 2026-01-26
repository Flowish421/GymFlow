using Domain.Enums;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class ExerciseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
    }
}
