using CourseStore.Model.Courses.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseStore.DAL.Courses;
public class CourseConfig : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.Property(c => c.Title).IsRequired().HasMaxLength(100);
        builder.Property(c => c.ShortDescription).IsRequired().HasMaxLength(500);
        builder.Property(c => c.Description).IsRequired();
        builder.Property(c => c.ImageURL).IsRequired().HasMaxLength(1000);
        builder.Property(c => c.Price).IsRequired().HasPrecision(14, 2);
        builder.Property(c => c.StartDate).HasColumnType("datetime2");
        builder.Property(c => c.EndDate).HasColumnType("datetime2");
        builder.ToTable("Courses", c => c.IsTemporal());
    }
}
