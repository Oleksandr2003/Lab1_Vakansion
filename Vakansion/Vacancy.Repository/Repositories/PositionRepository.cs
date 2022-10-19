using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Repository.Dto.PositionDto;
using Vakansion.Core;

namespace Vacancy.Repository.Repositories
{
    public class PositionRepository
    {
        private readonly VacancyContext _ctx;

        public PositionRepository(VacancyContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<PositionReadDto>> GetBodyTypesAsync()
        {

            var positionDto = _ctx.Positions.
            Select(x => new PositionReadDto
            {
                ClassId = x.ClassId,
                ClassName = x.ClassName,
                Vacancies = x.Vacancies,
            }).ToList();

            return positionDto;
        }
    }
}
