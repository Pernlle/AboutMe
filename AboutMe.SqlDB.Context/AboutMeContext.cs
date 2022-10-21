using AboutMe.Jobs.Domain.Model;
using AboutMe.School.Domain.Model;
using Microsoft.EntityFrameworkCore;
using AboutMe.SqlDB.Context.Configuration;



namespace AboutMe.SqlDB.Context
{
    public class AboutMeContext : DbContext
    {
        public AboutMeContext(DbContextOptions<AboutMeContext> options) : base(options)
        {

        }
        public DbSet<JobsEntity> JobsEntities { get; set; }
        public DbSet<SchoolEntity> SchoolEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new JobsTypeConfiguration());
            builder.ApplyConfiguration(new SchoolTypeConfiguration());

        }
    }
}
