using Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        public void InsertProduct(Product product);
        public void DeleteProduct(int productId);
        public void UpdateProduct(Product product);
        public Product GetProduct(int productId);
        public IEnumerable<Product> GetAllProducts();
    }
}
