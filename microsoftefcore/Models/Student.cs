using System;
using System.Collections.Generic;

namespace microsoftefcore.Models;

public partial class Student
{
    public int RollNo { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public long Phone { get; set; }

    public string Email { get; set; } = null!;

    public int Sid { get; set; }
}
