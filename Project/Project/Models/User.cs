using System;
using System.Collections.Generic;

namespace Project.Models;

public partial class User
{
    public int UId { get; set; }

    public string Account { get; set; } = null!;

    public string Password { get; set; } = null!;
}
