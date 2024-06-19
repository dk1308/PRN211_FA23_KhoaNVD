using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        public void InsertOrder(Orderr order);
        public void DeleteOrder(int orderId);
        public void UpdateOrder(Orderr order);
        public Orderr GetOrder(int orderId);
        public IEnumerable<Orderr> GetAllOrders();
    }
}
