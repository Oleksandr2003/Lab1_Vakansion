using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vakansion.Core;

namespace Vacancy.Repository.Dto.PositionDto
{
    public class PositionReadDto
    {
        public int ClassId { get; set; }
        public string? ClassName { get; set; }
        public virtual ICollection<Vacancys>? Vacancies { get; set; }
    }
}
