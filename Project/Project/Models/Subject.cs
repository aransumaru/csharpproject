using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; } = null!;

    public virtual ICollection<ClassStudentSubject> ClassStudentSubjects { get; set; } = new List<ClassStudentSubject>();

    public virtual ICollection<ScoreSubjectStudent> ScoreSubjectStudents { get; set; } = new List<ScoreSubjectStudent>();

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
