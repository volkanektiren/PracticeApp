using DesignPatterns.Creational.FactoryMethod.Creators.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PracticeApp.Areas.DesignPatterns.Controllers
{
    [Area("DesignPatterns")]
    public class FactoryMethodController(Creator creator) : Controller
    {
        public IActionResult Index()
        {
            ViewBag.OperationResult = creator.SomeOperation();

            return View();
        }
    }
}
