﻿using CourseStore.Model.Framework;

namespace CourseStore.Model.Courses.Entity;

public class CourseComment : BassEntity
{
    public int CourseId { get; set; }
    public Course Course { get; set; }
    public string CommentBy { get; set; }
    public string Comment { get; set; }
    public DateTime CommentDate { get; set; }
    public bool IsValid { get; set; }
}
