using Data_Access;
using Microsoft.AspNetCore.Mvc;

namespace MVC_News_App.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Users login)
        {
            UsersDao usersDao = new UsersDao();

            if (UsersDao.Instance.UserLogin(login.UserName, login.Password) == true)
            {
                return Redirect("Home/Index");
            }
            else
            {
                return View();
            }
        }
    }
}
