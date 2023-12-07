using Object;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(int productId)
        {
            try
            {
                Product product = ProductDAO.Instance.GetProduct(productId);
                if (product == null) throw new Exception("Not found product!");
                ProductDAO.Instance.DeleteProduct(productId);
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return ProductDAO.Instance.GetAll();
        }

        public Product GetProduct(int productId)
        {
            Product res = null;
            try
            {
                res = ProductDAO.Instance.GetProduct(productId);
                if (res == null) throw new Exception("Not found product!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return res;
        }

        public void InsertProduct(Product product)
        {
            try
            {
                ProductDAO.Instance.InsertProduct(product);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                Product findProduct = ProductDAO.Instance.GetProduct(product.ProductId);
                if (findProduct == null) throw new Exception("Not found product!");
                ProductDAO.Instance.UpdateProduct(product);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
