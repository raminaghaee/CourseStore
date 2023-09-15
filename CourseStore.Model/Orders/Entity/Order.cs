using CourseStore.Model.Courses.Entity;
using CourseStore.Model.Framework;

namespace CourseStore.Model.Orders.Entity;

public class Order : BassEntity
{
    public Course Course { get; set; }
    public DateTime OrderDate { get; set; }
    public string CustomerEmail { get; set; }
    public decimal TotalPrice { get; set; }
}
