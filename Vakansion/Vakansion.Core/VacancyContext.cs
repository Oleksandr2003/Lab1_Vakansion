using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<Vacancys> Vacancyses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Data> Datas { get; set; }
        public DbSet<Unemployed> Unemployeds { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
