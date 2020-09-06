using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            ViewBag.AInteger = 45;
            ViewBag.ADate = new DateTime(2020,9,5);

            ViewData["MyMessage"] = "This was with ViewData";

            return View();
        }
    }
}