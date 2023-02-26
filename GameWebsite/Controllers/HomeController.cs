using Microsoft.AspNetCore.Mvc;

namespace GameWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
