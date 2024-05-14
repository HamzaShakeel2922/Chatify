using Microsoft.AspNetCore.Mvc;

namespace Chatify.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
