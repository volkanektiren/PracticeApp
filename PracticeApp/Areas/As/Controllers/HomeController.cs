using Microsoft.AspNetCore.Mvc;
using PracticeApp.Data;

namespace PracticeApp.Areas.As.Controllers
{
    [Area("As")]
    public class HomeController(PracticeContext practiceContext) : Controller
    {
        public IActionResult Index()
        {
            practiceContext.As.Add(new());
            practiceContext.SaveChanges();

            var data = practiceContext.As.ToList();

            return View(data);
        }
    }
}
