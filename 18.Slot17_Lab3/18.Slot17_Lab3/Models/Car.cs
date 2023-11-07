using System;
using System.Collections.Generic;

namespace _18.Slot17_Lab3.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string CarName { get; set; } = null!;

    public string Manufacturer { get; set; } = null!;

    public double Price { get; set; }

    public int ReleasedYear { get; set; }
}
