using System;
using System.Collections.Generic;

namespace WebApp5byKrisha.Models;

public partial class Student
{
    public decimal Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Stream { get; set; }
}
