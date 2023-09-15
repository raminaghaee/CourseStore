using CourseStore.Model.Framework;
using CourseStore.Model.Tags.Entity;
using CourseStore.Model.Teachers.Entity;

namespace CourseStore.Model.Courses.Entity;
public class Course : BassEntity
{
    public string Title { get; set; }
    public string ShortDescription { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }
    public decimal Price { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public ICollection<CourseTeachers> Teachers { get; set; }
    public ICollection<CourseTag> CourseTags { get; set; }
    public ICollection<CourseComment> CourseComments { get; set; }
}
