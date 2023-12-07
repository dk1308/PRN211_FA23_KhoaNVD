using Library.DAOs;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace PRNWeb_MVC_2_Using_EF.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            MyDBContext db = new MyDBContext();
            List<Student> students = StudentDAO.Instance.GetAllStudents();
            return View(students);
        }

        public IActionResult Detail(int id)
        {
            MyDBContext db = new MyDBContext();
            Student student = StudentDAO.Instance.GetStudent(id);
            return View(student);
        }
    }
}
