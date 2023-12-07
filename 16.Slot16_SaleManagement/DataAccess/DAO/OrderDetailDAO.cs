using BusinessObject;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDetailDAO
    {
        public static OrderDetailDAO instance;
        public static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                        instance = new OrderDetailDAO();
                    return instance;
                }
            }
        }
        public void InsertOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using SmdbContext sm = new SmdbContext();
                sm.OrderDetails.Add(orderDetail);
                sm.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteOrderDetail(int orderId, int productId)
        {
            try
            {
                using SmdbContext sm = new SmdbContext();
                sm.OrderDetails.Remove(sm.OrderDetails.SingleOrDefault(o => o.OrderId == orderId
                                && o.ProductId == productId));
                sm.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public OrderDetail GetOrderDetail(int orderId, int productId)
        {
            OrderDetail res = null;
            try
            {
                using SmdbContext sm = new SmdbContext();
                res = sm.OrderDetails
                    .SingleOrDefault(o => o.OrderId == orderId
                                && o.ProductId == productId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return res;
        }
        public void UpdateOrderDetail(OrderDetail order)
        {
            try
            {
                using SmdbContext sm = new SmdbContext();
                sm.Entry<OrderDetail>(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                sm.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<OrderDetail> GetAll()
        {
            SmdbContext sm = new SmdbContext();
            return sm.OrderDetails
                .Include(o => o.Orderr)
                .Include(o => o.Product)
                .ToList();
        }
        public List<OrderDetail> GetAllByMember(int memberId)
        {
            SmdbContext sm = new SmdbContext();
            return sm.OrderDetails
                .Include(o => o.Orderr)
                .Include(o => o.Product)
                .Where(o => o.Orderr.MemberId == memberId)
                .ToList();
        }
    }
}
