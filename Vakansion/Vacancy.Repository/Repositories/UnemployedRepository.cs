using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Repository.Dto.UnemployedDto;
using Vakansion.Core;

namespace Vacancy.Repository.Repositories
{
    public class UnemployedRepository
    {
        private readonly VacancyContext _ctx;

        public UnemployedRepository(VacancyContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<UnemployedReadDto>> GetUnemployedAsync()
        {
            var unemployedDto = _ctx.Unemployeds
                .Select(x => new UnemployedReadDto
                {
                    ClassId = x.ClassId,
                    ClassName = x.ClassName,
                    DataId = x.DataId,
                    Datas = x.Datas,
                    EducationId = x.EducationId,
                    Educations = x.Educations,
                    Vacancies = x.Vacancies,
                }).ToList();

            return unemployedDto;
        }
    }
}
