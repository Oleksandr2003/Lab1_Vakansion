using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vakansion.Core
{
    public class VacancyContext : IdentityDbContext<User>
    {
        public VacancyContext(DbContextOptions<VacancyContext> options)
           : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
            base.OnModelCreating(builder);
        }
        public DbSet<Vacancy> Vacancys { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Data> Datas { get; set; }
        public DbSet<Unemployed> Unemployeds { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
