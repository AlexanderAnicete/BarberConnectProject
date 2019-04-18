using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarberConnectApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        

        public ActionResult About()
        {
            ViewBag.Message = "About Page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page";

            return View();
        }

        public ActionResult Settings()
        {
            ViewBag.Message = "Settings";

            return View();
        }

        public ActionResult Profile()
        {
            ViewBag.Message = "Profile Page";

            return View();
        }
    }

}