using CourseStore.Model.Courses.Entity;
using CourseStore.Model.Framework;

namespace CourseStore.Model.Teachers.Entity;

public class Teacher : BassEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<CourseTeachers> Courses { get; set; }
}
