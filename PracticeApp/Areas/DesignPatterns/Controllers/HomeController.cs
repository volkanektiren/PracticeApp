using DesignPatterns.Creational.AbstractFactory.Factories.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PracticeApp.Areas.DesignPatterns.Controllers
{
    [Area("DesignPatterns")]
    public class HomeController(IFactory factory) : Controller
    {
        public IActionResult Index()
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            var result = productB.AnotherUsefulFunctionB(productA);

            ViewBag.CollabrationResult = result;

            return View();
        }
    }
}
