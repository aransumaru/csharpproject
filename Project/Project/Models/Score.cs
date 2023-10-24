using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class Score
{
    public int ScoreId { get; set; }

    public int? Lab1 { get; set; }

    public int? Lab2 { get; set; }

    public int? Assignment { get; set; }

    public int? TheoryExam { get; set; }

    public int? PracticalExam { get; set; }

    public virtual ICollection<ScoreSubjectStudent> ScoreSubjectStudents { get; set; } = new List<ScoreSubjectStudent>();
}
