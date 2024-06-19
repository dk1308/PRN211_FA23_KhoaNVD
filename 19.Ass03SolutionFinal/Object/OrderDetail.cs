using System;
using System.Collections.Generic;

namespace Object;

public partial class OrderDetail
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public double UnitPrice { get; set; }

    public int Quantity { get; set; }

    public double Discount { get; set; }

    public virtual Orderr Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
