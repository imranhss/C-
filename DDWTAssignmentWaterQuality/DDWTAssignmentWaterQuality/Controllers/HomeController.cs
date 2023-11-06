﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDWTAssignmentWaterQuality.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Active = "Index";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Active = "About";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Active = "Contact";
            return View();
        }

        public ActionResult System()
        {
            ViewBag.Active = "System";
            return View();
        }

        public ActionResult Parameter()
        {
            ViewBag.Active = "Parameter";
            return View();
        }

        public ActionResult DisinfectionMethod()
        {
            ViewBag.Active = "DisinfectionMethod";
            return View();
        }
    }
}