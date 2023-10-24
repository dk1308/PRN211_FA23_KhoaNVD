using ManageCategoriesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCategoriesApp.Data_Access
{
    public sealed class ManageCategories
    {
        // Using singleton pattern
        public static ManageCategories instance = null;
        public static readonly object instanceLock = new object();
        public static ManageCategories Instance
        {
            get {
                lock (instanceLock)
                {
                    if (instance == null) instance = new ManageCategories();
                    return instance;
                }
            }
        }

        // Controller method
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            try
            {
                using MyStock myStock = new MyStock();
                categories = myStock.Categories.ToList();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return categories;
        }


        public void InsertCategory(Category category)
        {
            try
            {
                using MyStock myStock = new MyStock();
                myStock.Categories.Add(category);
                myStock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateCategory(Category category) 
        {
            try
            {
                using MyStock myStock = new MyStock();
                myStock.Entry<Category>(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                myStock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteCategory(int categoryID)
        {
            try
            {
                using MyStock myStock = new MyStock();
                myStock.Categories.Remove(myStock.Categories.SingleOrDefault(c => c.CategoryId == categoryID));
                myStock.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
