using CourseStore.Model.Courses.Entity;
using CourseStore.Model.Orders.Entity;
using CourseStore.Model.Tags.Entity;
using CourseStore.Model.Teachers.Entity;
using Microsoft.EntityFrameworkCore;

namespace CourseStore.DAL.DbContexts;
public class CourseStoreDbCoubtex : DbContext
{
    

    public DbSet<Course> Courses { get; set; }
    public DbSet<Teacher>  Teachers { get; set; }
    public DbSet<CourseTeachers> CourseTeachers { get; set; }
    public DbSet<CourseComment> CourseComments  { get; set; }
    public DbSet<Tag> Tags  { get; set; }
    public DbSet<Order>  Orders { get; set; }
    public DbSet<CourseTag>  CourseTags { get; set; }


    public CourseStoreDbCoubtex(DbContextOptions options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        foreach (var item in modelBuilder.Model.GetEntityTypes())
        {
            modelBuilder.Entity(item.ClrType).Property<String>("CreateBy").HasMaxLength(50);
            modelBuilder.Entity(item.ClrType).Property<String>("UpdateBy").HasMaxLength(50);
            modelBuilder.Entity(item.ClrType).Property<DateTime>("UpdateDate");
            modelBuilder.Entity(item.ClrType).Property<DateTime>("CreateDate");
        }
    }

}

