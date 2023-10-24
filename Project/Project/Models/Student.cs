using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;

    public virtual ICollection<ClassStudentSubject> ClassStudentSubjects { get; set; } = new List<ClassStudentSubject>();

    public virtual ICollection<ScoreSubjectStudent> ScoreSubjectStudents { get; set; } = new List<ScoreSubjectStudent>();

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
