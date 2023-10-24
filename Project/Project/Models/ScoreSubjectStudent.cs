using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class ScoreSubjectStudent
{
    public int SssId { get; set; }

    public int ScoreId { get; set; }

    public int StudentId { get; set; }

    public int SubjectId { get; set; }

    public virtual Score Score { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
