using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccess.Repository;
using Object;
using Microsoft.IdentityModel.Tokens;

namespace eStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository productRepo;

        public ProductsController()
        {
            productRepo = new ProductRepository();
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            string account = HttpContext.Session.GetString("account");

            if (account.IsNullOrEmpty())
            {
                ViewData["Message"] = "Incorrect email and password";
                return RedirectToAction("Index", "Login");
            }

            return productRepo.GetAllProducts() != null ? 
                          View(productRepo.GetAllProducts()) :
                          Problem("Entity set 'SmdbContext.Products'  is null.");
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || productRepo.GetAllProducts() == null)
            {
                return NotFound();
            }

            var product = productRepo.GetAllProducts()
                .FirstOrDefault(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,CategoryId,ProductName,Weight,UnitPrice,UnitsInStock")] Product product)
        {
            if (ModelState.IsValid)
            {
                productRepo.InsertProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || productRepo.GetAllProducts() == null)
            {
                return NotFound();
            }

            var product = productRepo.GetProduct(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,CategoryId,ProductName,Weight,UnitPrice,UnitsInStock")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    productRepo.UpdateProduct(product);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || productRepo.GetAllProducts() == null)
            {
                return NotFound();
            }

            var product = productRepo.GetAllProducts()
                .FirstOrDefault(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (productRepo.GetAllProducts() == null)
            {
                return Problem("Entity set 'SmdbContext.Products'  is null.");
            }
            var product = productRepo.GetProduct(id);
            if (product != null)
            {
                productRepo.DeleteProduct(id);
            }
            
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
          return (productRepo.GetAllProducts()?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }
    }
}
