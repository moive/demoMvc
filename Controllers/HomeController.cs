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
            var route = Server.MapPath("texto.txt");
            return File(route,"Text/Plain","text-custom.txt") ;
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