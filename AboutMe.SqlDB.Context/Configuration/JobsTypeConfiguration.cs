using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AboutMe.Jobs.Domain.Model;

namespace AboutMe.SqlDB.Context.Configuration
{
    public class JobsTypeConfiguration : IEntityTypeConfiguration<JobsEntity>
    {
        public void Configure(EntityTypeBuilder<JobsEntity> builder)
        {
            builder.ToTable("Jobs", "Jobs");
            builder.HasKey(x => x.JobId);
        }
    }
}
