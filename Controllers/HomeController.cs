using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoMvc.Controllers
{

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            Person person1 = new Person() { Name = "Moises", Age = 38 };
            Person person2 = new Person() { Name = "Daniela", Age = 6 };

            return Json(new List<Person>() {person1, person2 }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}