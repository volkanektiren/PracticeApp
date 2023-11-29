using Microsoft.AspNetCore.Mvc;

namespace PracticeApp.Areas.DesignPatterns.Controllers
{
    [Area("DesignPatterns")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
