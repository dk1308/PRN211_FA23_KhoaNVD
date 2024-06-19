using WebMVCApplyDI.Models;

namespace WebMVCApplyDI.Services
{
    public class ProductService
    {
        List<Product> products = new List<Product>()
        {
            new Product{ID = 1, Name = "Iphone14", Price =100},
            new Product{ID = 2, Name = "Iphone14 Promax", Price =130},
            new Product{ID = 3, Name = "Iphone15", Price =120},
            new Product{ID = 4, Name = "Iphone15 Promax", Price =150}
        };
        public Product FindProductById(string id)
        {
            try
            {
                int idAsNumber = int.Parse(id);
                Product product = products.FirstOrDefault(p => p.ID == idAsNumber);
                return product;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
