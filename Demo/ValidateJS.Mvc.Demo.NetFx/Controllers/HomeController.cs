using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidateJS.Mvc.NetStandard;

namespace ValidateJS.Mvc.Demo.NetFx.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var logger = new AppLogger();
            logger.Log("Hello");
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

            return View();
        }
    }
}