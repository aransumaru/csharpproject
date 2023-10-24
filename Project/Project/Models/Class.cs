using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Class
{
    public int ClassId { get; set; }

    public string ClassName { get; set; } = null!;

    public virtual ICollection<ClassStudentSubject> ClassStudentSubjects { get; set; } = new List<ClassStudentSubject>();
}
