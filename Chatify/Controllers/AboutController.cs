using Microsoft.AspNetCore.Mvc;

namespace Chatify.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "About Page";
            return View();
        }
    }
}
