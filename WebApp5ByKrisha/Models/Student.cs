using System;
using System.Collections.Generic;

namespace WebApp5ByKrisha.Models;

public partial class Student
{
    public decimal Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string? Faculty { get; set; }
}
