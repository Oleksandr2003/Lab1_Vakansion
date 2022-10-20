using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Repository.Dto.VacancyDto;
using Vakansion.Core;

namespace Vacancy.Repository.Repositories
{
    public class VacancyRepository
    {
        private readonly VacancyContext _ctx;

        public VacancyRepository(VacancyContext ctx, UnemployedRepository unemployedRepository)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<VacancyReadDto>> GetVacancyAsync()
        {
            var vacancyDto = _ctx.Vacancyses
                .Select(x => new VacancyReadDto
                {
                    VacancyId = x.VacancysId,
                    PositionId = x.PositionId,
                    Positions = x.Positions,
                    EmployerId = x.EmployerId,
                    Employers = x.Employers,
                    UnemployedId = x.UnemployedId,
                    Unemployeds = x.Unemployeds,
                }).ToList();

            return vacancyDto;
        }
    }
}
