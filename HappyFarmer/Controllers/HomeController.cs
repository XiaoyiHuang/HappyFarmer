﻿using System.Web.Mvc;

namespace HappyFarmer.Controllers
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
        
        public ActionResult Dashboard()
        {
            return View();
        }

        public new ActionResult Profile()
        {
            return View();
        }

        public ActionResult Register()
        {
            return PartialView();
        }

        public ActionResult Login()
        {
            return PartialView();
        }
    }
}