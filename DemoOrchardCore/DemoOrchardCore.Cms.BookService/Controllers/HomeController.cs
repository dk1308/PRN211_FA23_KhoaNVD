using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOrchardCore.Cms.BookService.Controllers
{
    [ApiController]
    [Route("api/v1/book")]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return Ok("Hello World");
        }
    }
}
