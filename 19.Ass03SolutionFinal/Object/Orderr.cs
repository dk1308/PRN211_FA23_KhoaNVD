using System;
using System.Collections.Generic;

namespace Object;

public partial class Orderr
{
    public int OrderId { get; set; }

    public int MemberId { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime? RequiredDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public double? Freight { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
