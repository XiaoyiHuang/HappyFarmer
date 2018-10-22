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

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}