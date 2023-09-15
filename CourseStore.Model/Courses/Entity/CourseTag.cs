using CourseStore.Model.Framework;
using CourseStore.Model.Teachers.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Model.Courses.Entity;
public class CourseTag : BassEntity
{
    public int CourseId { get; set; }
    public int TeacherId { get; set; }
    public Teacher  Teacher { get; set; }
    public Course Course { get; set; }
}

