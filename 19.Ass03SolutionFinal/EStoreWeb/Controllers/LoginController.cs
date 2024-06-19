using DataAccess.Repository;
using EStoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Object;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace eStore.Controllers
{
    public class LoginController : Controller
    {
        private Admin admin;
        private readonly IMemberRepository memberRepo;
        public LoginController()
        {
            memberRepo = new MemberRepository();

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);
            IConfiguration configuration = builder.Build();
            admin = configuration.GetSection("AdminAccount").Get<Admin>();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string email, string password)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);
            IConfiguration configuration = builder.Build();
            admin = configuration.GetSection("AdminAccount").Get<Admin>();

            if (email.Equals(admin.Email) && password.Equals(admin.Password))
            {
                HttpContext.Session.SetString("account", "admin");
                return RedirectToAction("Index", "Members");
            }
                    
            
            Member member = memberRepo.Login(new Member
            {
                Email = email,
                Password = password
            });

            if(member != null)
            {
                HttpContext.Session.SetString("account", email);
                return RedirectToAction("Shopping", "OrderDetails");
            }
            ViewData["Message"] = "Incorrect email and password";
            return View();
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("account");
            return View("Index");
        }
    }
}
