using CourseStore.Model.Courses.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseStore.DAL.Courses;
public class CourseTeacherConfig : IEntityTypeConfiguration<CourseTeachers>
{
    public void Configure(EntityTypeBuilder<CourseTeachers> builder)
    {
        builder.ToTable("CourseTeachers", c => c.IsTemporal());
    }
}

