using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class ClassStudentSubject
{
    public int ClassId { get; set; }

    public int StudentId { get; set; }

    public int SubjectId { get; set; }

    public virtual Class Class { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
