using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vakansion.Core;
using Vacancy.Repository.Repositories;
using Vacancy.Repository.Dto.DataDto;

namespace Vacancy.Repository.Repositories
{
    public class DataRepository
    {
        private readonly VacancyContext _ctx;

        public DataRepository(VacancyContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<DataReadDto>> GetBodyTypesAsync()
        {

            var dataDto = _ctx.Datas.
            Select(x => new DataReadDto
            {
                ClassId = x.ClassId,
                ClassName = x.ClassName,
                Unemployed = x.Unemployeds,
                Vacancies = x.Vacancies,
            }).ToList();

          return dataDto;
        }
                                   
    }

}

