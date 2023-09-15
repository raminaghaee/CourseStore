using CourseStore.Model.Courses.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseStore.DAL.Courses;
public class CommentConfig : IEntityTypeConfiguration<CourseComment>
{
    public void Configure(EntityTypeBuilder<CourseComment> builder)
    {
        //builder.Property(c => c.Course).IsRequired();
        builder.Property(c => c.CommentBy).IsRequired().HasMaxLength(50);
        builder.Property(c => c.CommentDate).HasColumnType("datetime2");
        builder.Property(c => c.IsValid).HasDefaultValue(false);
        builder.ToTable("CourseComments", c => c.IsTemporal());
    }
}

