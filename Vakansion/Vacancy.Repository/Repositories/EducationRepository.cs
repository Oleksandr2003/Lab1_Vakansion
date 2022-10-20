using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Repository.Dto.EducationDto;
using Vakansion.Core;

namespace Vacancy.Repository.Repositories
{
    public class EducationRepository
    {
        private readonly VacancyContext _ctx;

        public EducationRepository(VacancyContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<EducationReadDto>> GetEducationAsync()
        {

            var educationDto = _ctx.Educations.
            Select(x => new EducationReadDto
            {
                ClassId = x.ClassId,
                ClassName = x.ClassName,
                Unemployed = x.Unemployeds,
                Vacancies = x.Vacancies,
            }).ToList();

            return educationDto;
        }
    }
}
