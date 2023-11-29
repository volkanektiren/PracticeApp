using DesignPatterns.Creational.Builder;
using Microsoft.AspNetCore.Mvc;

namespace PracticeApp.Areas.DesignPatterns.Controllers
{
    [Area("DesignPatterns")]
    public class BuilderController : Controller
    {
        public IActionResult Index()
        {
            var builderA = new ABuilder();
            var builderB = new BBuilder();

            Director.BuildMinimalValuableProduct(builderA);

            var productA = builderA.GetProduct();

            Director.BuildFullFeaturedProduct(builderB);

            var productB = builderB.GetProduct();

            ViewBag.ProductA = productA.ListParts();
            ViewBag.ProductB = productB.ListParts();

            return View();
        }
    }
}
