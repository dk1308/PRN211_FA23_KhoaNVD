using BusinessObject.Models;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(int orderId)
        {
            try
            {
                Orderr order = OrderDAO.Instance.GetOrder(orderId);
                if (order == null) throw new Exception("Not found order!");
                OrderDAO.Instance.DeleteOrder(orderId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Orderr> GetAllOrders()
        {
            return OrderDAO.Instance.GetAll();
        }

        public Orderr GetOrder(int orderId)
        {
            Orderr res = null;
            try
            {
                res= OrderDAO.Instance.GetOrder(orderId);
                if (res == null) throw new Exception("Not found order!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return res;
        }

        public void InsertOrder(Orderr order)
        {
            try
            {
                Orderr findOrder = OrderDAO.Instance.GetOrder(order.OrderId);
                if (findOrder != null) throw new Exception("Order already exists!");
                if (MemberDAO.Instance.GetMember(order.MemberId) == null)
                    throw new Exception("Not found member!");
                OrderDAO.Instance.InsertOrder(order);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateOrder(Orderr order)
        {
            try
            {
                Orderr findOrder = OrderDAO.Instance.GetOrder(order.OrderId);
                if (findOrder == null) throw new Exception("Not found order!");
                OrderDAO.Instance.UpdateOrder(order);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
