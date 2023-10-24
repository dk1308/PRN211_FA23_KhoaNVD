using EntityProgram.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a DBContext object
            MyStoreContext myStore = new MyStoreContext();
            // Print all Products
            var products = from p in myStore.Products
                           select new {p.ProductName, p.CategoryId};
            foreach (var p in products)
            {
                Console.WriteLine($"ProductName: {p.ProductName}, CategoryID: {p.CategoryId}");
            }

            // A query to get all Categories and their related products
            IQueryable<Category> cats = myStore.Categories.Include(c => c.Products);
            foreach (Category c in cats)
            {
                Console.WriteLine($"CategoryID: {c.CategoryId} has {c.Products.Count} products.");
            }
            Console.ReadLine();
        }
    }
}

