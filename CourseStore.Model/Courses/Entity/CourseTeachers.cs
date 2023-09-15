using CourseStore.Model.Framework;
using CourseStore.Model.Teachers.Entity;

namespace CourseStore.Model.Courses.Entity;

public class CourseTeachers : BassEntity
{
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public int SortOrder { get; set; }

}
