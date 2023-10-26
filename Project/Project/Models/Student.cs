using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public DateTime? Dob { get; set; }

    public string? Sex { get; set; }

    public virtual ICollection<ClassStudentSubject> ClassStudentSubjects { get; set; } = new List<ClassStudentSubject>();

    public virtual ICollection<ScoreSubjectStudent> ScoreSubjectStudents { get; set; } = new List<ScoreSubjectStudent>();
}
