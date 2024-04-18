using IntroductionToDb.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroductionToDb.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            var db = new BlogContext();
            return View(db.blogs.ToList());
        }
    }
}
