using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vakansion.Core;

namespace Vacancy.Repository.Dto.EducationDto
{
    public class EducationReadDto
    {
        public int ClassId { get; set; }
        public string? ClassName { get; set; }
        public Unemployed? Unemployed { get; internal set; }
        public virtual ICollection<Vacancys>? Vacancies { get; set; }
    }
       
        
}
