using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vakansion.Core;

namespace Vacancy.Repository.Dto.VacancyDto
{
    public class VacancyReadDto
    {
        public int VacancyId { get; set; }

        public int PositionId { get; set; }
        public Position? Positions { get; set; }

        public int EmployerId { get; set; }
        public Employer? Employers { get; set; }

        public int UnemployedId { get; set; }
        public Unemployed? Unemployeds { get; set; }
    }
}
