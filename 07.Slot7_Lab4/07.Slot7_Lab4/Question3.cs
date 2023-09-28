using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string[] Colors { get; set; }
        public int Brand {  get; set; } 
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            Id = id;
            Name = name;
            Price = price;
            Colors = colors;
            Brand = brand;
        }

        public override string ToString()
        => $"{Id,3} {Name,12} {Price,5} {Brand,2} {string.Join(", ", Colors)}";        
    }

    class Brand
    {
        public int Id { get; set; }
        public string Name { set; get; }
    }

    class MyClass3 {
        static void Main(string[] args)
        {
            // initialize  list brands
            var brands = new List<Brand>
        {
            new Brand { Id = 1, Name = "Công ty A" },
            new Brand { Id = 2, Name = "Công ty B" },
            new Brand { Id = 3, Name = "Công ty C" }
        };

            // initialize  list products
            var products = new List<Product>
        {
            new Product(1, "Bàn ăn", 400, new string[]{"xám", "xanh"}, 2),
            new Product(2, "Bàn học", 400, new string[]{"vàng", "xanh"}, 1),
            new Product(3, "Tranh treo", 500, new string[]{"trắng"}, 3),
            new Product(4, "Bàn trang điểm", 200, new string[]{"trắng", "đen"}, 1),
            new Product(5, "Đèn chùm", 300, new string[]{"đỏ", "tím"}, 2),
            new Product(6, "Tủ áo", 500, new string[]{"trắng"}, 2),
            new Product(7, "Chăn", 350, new string[]{"trắng"}, 3)
        };


            // question a - find products whose price equals 400
            var product_a = from productA in products
                            where productA.Price == 400
                            select productA;
            Console.WriteLine("Question a");
            foreach (var item in product_a)
            {
                Console.WriteLine(item);
            }

            // question b - find products whose color cotains yellow 
            var product_b = from productB in products
                            where productB.Colors.Contains("vàng") 
                            select productB;
            Console.WriteLine("\n\nQuestion b");
            foreach (var item in product_b)
            {
                Console.WriteLine(item);
            }

            // question c - sort descending
            var product_c = products.OrderBy(x => -x.Price).ToList();
            Console.WriteLine("\n\nQuestion c");
            foreach (var item in product_c)
            {
                Console.WriteLine(item);
            }
        }
    }
}
