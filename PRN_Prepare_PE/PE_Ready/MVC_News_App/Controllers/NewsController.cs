using Data_Access;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MVC_News_App.Controllers
{
    public class NewsController : Controller
    {
        private readonly PeDB context;
        public NewsController(PeDB context) => this.context = context;
        

        // GET: NewsController
        public ActionResult Index()
        {
            var model = context.News.Include(p => p.Users).Include(d=>d.Categories).ToList();
            return View(model);
        }

        // GET: NewsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewsController/Create
        public ActionResult Create()
        {
            ViewBag.Categories = CategoryDao.Instance.GetAllCategories().ToList();
            ViewBag.Users = UsersDao.Instance.GetAllUsers().ToList();
            return View();
        }

        // POST: NewsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(News news)
        {
          
                if (ModelState.IsValid)
                {
                    NewsDao.Instance.InsertNews(news);
                }

            return Redirect("Index");
            
        }

        // GET: NewsController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Categories = CategoryDao.Instance.GetAllCategories().ToList();
            ViewBag.Users = UsersDao.Instance.GetAllUsers().ToList();

            News news = NewsDao.Instance.findNewsById(id);
            
            return View(news);
        }

        // POST: NewsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(News news)
        {
            if (news.DateUpdate == null) news.DateUpdate = DateTime.Now;
                NewsDao.Instance.UpdateNews(news);
            return RedirectToAction("Index");
        }

      
        public ActionResult Delete(int id)
        {
            NewsDao.Instance.DeleteNews(NewsDao.Instance.findNewsById(id));
            return RedirectToAction("Index");
        }
    }
}
