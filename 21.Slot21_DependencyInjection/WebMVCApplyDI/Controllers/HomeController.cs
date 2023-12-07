using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebMVCApplyDI.Models;
using WebMVCApplyDI.Services;

namespace WebMVCApplyDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductService productService;
        public HomeController(ILogger<HomeController> logger, ProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product(string id)
        {
            Product p = productService.FindProductById(id);
            return View("Index", p);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}