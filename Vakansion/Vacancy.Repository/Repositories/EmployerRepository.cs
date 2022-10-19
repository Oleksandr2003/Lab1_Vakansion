using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vacancy.Repository.Dto.EmployerDto;
using Vakansion.Core;

namespace Vacancy.Repository.Repositories
{
    public class EmployerRepository
    {
        private readonly VacancyContext _ctx;

        public EmployerRepository(VacancyContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<EmployerReadDto>> GetBodyTypesAsync()
        {

            var employerDto = _ctx.Employers.
            Select(x => new EmployerReadDto
            {
                ClassId = x.ClassId,
                ClassName = x.ClassName,               
                Vacancies = x.Vacancies,
            }).ToList();

            return employerDto;
        }
    }
}
