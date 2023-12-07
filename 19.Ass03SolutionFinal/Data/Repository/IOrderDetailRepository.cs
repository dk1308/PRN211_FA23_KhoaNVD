using Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        public void InsertOrderDetail(OrderDetail orderDetail);
        public void DeleteOrderDetail(int orderId, int productId);
        public void UpdateOrderDetail(OrderDetail orderDetail);
        public OrderDetail GetOrderDetail(int orderId, int productId);
        public IEnumerable<OrderDetail> GetAllOrderDetails();
        public IEnumerable<OrderDetail> GetAllOrderDetailsByMemberId(int memberId);
    }
}
