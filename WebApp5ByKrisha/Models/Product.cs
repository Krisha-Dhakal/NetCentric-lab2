using System;
using System.Collections.Generic;

namespace WebApp5ByKrisha.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public string Description { get; set; } = null!;
}
