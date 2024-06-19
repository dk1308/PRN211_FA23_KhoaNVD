using Microsoft.AspNetCore.Mvc;
using PracticePRN.Models;
using System.Data;
using System.Xml.Linq;

namespace PracticePRN.Controllers
{
    public class CourseController : Controller
    {
        [BindProperty (SupportsGet =true)]
        public string Descript {  get; set; }
        public IActionResult List()
        {
            ViewData["title"] = "List of course - ViewData";
            ViewBag.Content = "This is list of course page! - ViewBag";

            List<String> list = new List<string> { "Java", "Javascript", "C#", "ASP .NET" };

            return View(list);
        }
        public IActionResult Detail()
        {
            ViewData["title"] = "Info of course - ViewData";
            ViewBag.Content = "This is info of course page! - ViewBag";
            return View();
        }

        public string Show()
        {
            int id = Convert.ToInt16(Request.Query["id"]);
            string name = Request.Query["name"];
            return $"ID: {id}, Name: {name}";
        }

        public string ShowUseModelBinding(int id, string name)
        {
            return $"ID: {id}, Name: {name}";
        }

        public string ShowPublicProperty()
        {
            return $"Description: {Descript}";
        }

        public IActionResult FormAddCourses()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FormAddCourses(Course course)
        {
            return View("Detail", course);
        }
    }
}
