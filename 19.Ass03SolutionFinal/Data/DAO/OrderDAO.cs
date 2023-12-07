using Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDAO
    {
        public static OrderDAO instance;
        public static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                        instance = new OrderDAO();
                    return instance;
                }
            }
        }
        public void InsertOrder(Orderr order)
        {
            try
            {
                using SmdbContext sm = new SmdbContext();
                sm.Orderrs.Add(order);
                sm.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteOrder(int orderId)
        {
            try
            {
                using SmdbContext sm = new SmdbContext();
                sm.Orderrs.Remove(sm.Orderrs.SingleOrDefault(o => o.OrderId== orderId));
                sm.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Orderr GetOrder(int orderId)
        {
            Orderr res = null;
            try
            {
                using SmdbContext sm = new SmdbContext();
                res = sm.Orderrs.SingleOrDefault(o => o.OrderId == orderId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return res;
        }
        public void UpdateOrder(Orderr order)
        {
            try
            {
                using SmdbContext sm = new SmdbContext();
                sm.Entry<Orderr>(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                sm.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Orderr> GetAll()
        {
            SmdbContext saleManagementDbContext = new SmdbContext();
            return saleManagementDbContext.Orderrs.ToList();
        }
    }
}
