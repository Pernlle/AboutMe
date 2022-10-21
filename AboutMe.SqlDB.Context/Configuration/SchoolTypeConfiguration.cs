using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AboutMe.School.Domain.Model;

namespace AboutMe.SqlDB.Context.Configuration
{
    public class SchoolTypeConfiguration : IEntityTypeConfiguration<SchoolEntity>
    {
        public void Configure(EntityTypeBuilder<SchoolEntity> builder)
        {
            builder.ToTable("School", "School");
            builder.HasKey(x => x.SchoolId);
        }
    }
}
