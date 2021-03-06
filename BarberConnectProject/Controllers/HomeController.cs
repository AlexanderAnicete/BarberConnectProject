﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BarberConnectProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Barber Connect is a website and application that will be able to connect " +
                "Barbers and customers easier than ever. For Barbers, they can create a profile and showcase " +
                "their work and what they're all about. Barbers will be able to post pictures of their work, create " +
                "a bio to introduce themselves, post their schedule, prices they charge for a haircut, set up " +
                "appointments to cut at their shop and even meet the customer. For customers, this app will be a " +
                "much more seemless way of finding a local barber that they can trust by simply looking up a profile " +
                "and even being able to choose if they want a haircut at home. This idea was inspired when I've always " +
                "been able to find a barber shop, but never a barber that I could trust to give me that fresh haircut we " +
                "all deserve..";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}