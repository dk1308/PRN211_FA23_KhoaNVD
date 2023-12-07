using Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class ProductDAO
    {
        public static ProductDAO instance;
        public static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                        instance = new ProductDAO();
                    return instance;
                }
            }
        }

        public void InsertProduct(Product product)
        {
            try
            {
                SmdbContext sm = new SmdbContext();
                sm.Products.Add(product);
                sm.SaveChanges();
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteProduct(int productId)
        {
            try
            {
                SmdbContext sm = new SmdbContext();
                sm.Products.Remove(sm.Products.SingleOrDefault(p => p.ProductId == productId));
                sm.SaveChanges();
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
                SmdbContext sm = new SmdbContext();
                sm.Entry<Product>(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                sm.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Product GetProduct(int productId)
        {
            Product res = null;
            try
            {
                SmdbContext sm = new SmdbContext();
                res = sm.Products.SingleOrDefault(p => p.ProductId == productId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return res;
        }

        public List<Product> GetAll()
        {
            SmdbContext sm = new SmdbContext();
            return sm.Products.ToList();
        }
    }
}
