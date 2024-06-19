using BusinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void DeleteOrderDetail(int orderId, int productId)
        {
            try
            {
                OrderDetail orderDetail = OrderDetailDAO.Instance.GetOrderDetail(orderId, productId);
                if (orderDetail == null) throw new Exception("Not found order detail!");
                OrderDetailDAO.Instance.DeleteOrderDetail(orderId, productId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return OrderDetailDAO.Instance.GetAll();
        }

        public IEnumerable<OrderDetail> GetAllOrderDetailsByMemberId(int memberId)
        {
            return OrderDetailDAO.Instance.GetAllByMember(memberId);
        }

        public OrderDetail GetOrderDetail(int orderId, int productId)
        {
            OrderDetail res = null;
            try
            {
                res = OrderDetailDAO.Instance.GetOrderDetail(orderId, productId);
                if (res == null) throw new Exception("Not found order detail!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return res;
        }

        public void InsertOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                if (ProductDAO.Instance.GetProduct(orderDetail.ProductId) == null)
                    throw new Exception("Not found product!");
                OrderDetailDAO.Instance.InsertOrderDetail(orderDetail);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                OrderDetail findOrderDetail = OrderDetailDAO.Instance.GetOrderDetail(orderDetail.OrderId, orderDetail.ProductId);
                if (findOrderDetail == null) throw new Exception("Not found order detail!");
                OrderDetailDAO.Instance.UpdateOrderDetail(orderDetail);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
