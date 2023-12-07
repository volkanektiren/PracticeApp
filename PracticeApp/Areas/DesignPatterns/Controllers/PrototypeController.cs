using DesignPatterns.Creational.Prototype;
using Microsoft.AspNetCore.Mvc;

namespace PracticeApp.Areas.DesignPatterns.Controllers
{
    [Area("DesignPatterns")]
    public class PrototypeController : Controller
    {
        public IActionResult Index()
        {
            var  p1 = new Person()
            {
                Age = 42,
                BirthDate = Convert.ToDateTime("1977-01-01"),
                Name = "Jack Daniels",
                IdInfo = new IdInfo(666)
            };

            var p2 = p1.ShallowCopy();
            var p3 = p1.DeepCopy();

            p1.Age = 32;
            p1.BirthDate = Convert.ToDateTime("1900-01-01");
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;

            ViewBag.Person1 = p1;
            ViewBag.Person2 = p2;
            ViewBag.Person3 = p3;

            return View();
        }
    }
}
