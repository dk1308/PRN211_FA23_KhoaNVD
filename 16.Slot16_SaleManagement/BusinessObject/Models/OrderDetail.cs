using System;
using System.Collections.Generic;
namespace BusinessObject.Models;

public partial class OrderDetail
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public int Quantity { get; set; }

    public double Discount { get; set; }

    public virtual Orderr Orderr { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    public double TotalMoney (){ 
            double moneyEachProduct = Convert.ToInt16(Product.UnitPrice) * Quantity;
            double discountMoney = Discount * moneyEachProduct;
            double freight = Convert.ToInt16(Orderr.Freight);
            return moneyEachProduct+freight-discountMoney;        
    }
}
