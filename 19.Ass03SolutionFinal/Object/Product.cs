using System;
using System.Collections.Generic;

namespace Object;

public partial class Product
{
    public int ProductId { get; set; }

    public int CategoryId { get; set; }

    public string ProductName { get; set; } = null!;

    public double Weight { get; set; }

    public double UnitPrice { get; set; }

    public int UnitsInStock { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
