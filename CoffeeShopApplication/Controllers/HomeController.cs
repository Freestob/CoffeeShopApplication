﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShopApplication.Controllers
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

            return View();
        }

        public ActionResult Registration_Page()
        {
            ViewBag.Message = "This is where you register.";

            return View();
        }

        public ActionResult StoreInfo(string addName, string addEmail)
        {
            ViewBag.Message = $"Hello {addName} we sent a verification email to {addEmail}. Please check your inbox";

            return View();
        }
    }
}