using CourseStore.Model.Courses.Entity;
using CourseStore.Model.Framework;

namespace CourseStore.Model.Tags.Entity;

public class Tag : BassEntity
{
    public string TagName { get; set; }
    public ICollection<CourseTag> CourseTags{ get; set; }
}
