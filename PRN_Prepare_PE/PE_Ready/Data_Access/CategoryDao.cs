using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access
{
    public class CategoryDao
    {

        private static CategoryDao instance = null;
        private static readonly object instanceLock = new object();
        public CategoryDao() { }
        public static CategoryDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDao();
                    }
                    return instance;
                }
            }
        }

        public List<Categories> GetAllCategories()
        {
            List<Categories> Categoriess;
            try
            {
                using PeDB stock = new PeDB();
                Categoriess = stock.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Categoriess;
        }

        public void InsertCategory(Categories Category)
        {
            try
            {
                using PeDB stock = new PeDB();
                stock.Categories.Add(Category);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateCategory(Categories Category)
        {
            try
            {
                using PeDB stock = new PeDB();
                stock.Entry<Categories>(Category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteCategory(Categories Category)
        {
            try
            {
                using PeDB stock = new PeDB();
                var p = stock.Categories.SingleOrDefault(c => c.CatetoryID == Category.CatetoryID);
                stock.Categories.Remove(p);
                stock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Categories findCategoryById(int Categoryid)
        {
            try
            {
                using PeDB stock = new PeDB();
                var p = stock.Categories.SingleOrDefault(c => c.CatetoryID == Categoryid);
                return p;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
