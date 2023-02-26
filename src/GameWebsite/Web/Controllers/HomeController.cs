using Microsoft.AspNetCore.Mvc;

namespace GameWebsite.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
