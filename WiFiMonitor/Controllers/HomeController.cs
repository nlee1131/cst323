using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WiFiMonitor.Models;
using WiFiMonitor.Services;

namespace WiFiMonitor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ServerDAO service = new ServerDAO();
            List<WiFiModel> model = service.GetSpeeds();
            return View("Index", "", model);
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