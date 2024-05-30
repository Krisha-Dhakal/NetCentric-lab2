using System;
using System.Collections.Generic;

namespace WebApp5byKrisha.Models;

public partial class College
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;
}
