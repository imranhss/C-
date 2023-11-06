using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDWTAssignmentWaterQuality.Controllers
{
    public class DisinfectionMethodController : Controller
    {
        // GET: DisinfectionMethod
        public ActionResult Index()
        {
            ViewBag.Active = "DisinfectionMethod";
            return View();
        }
        public ActionResult Details()
        {
            ViewBag.Active = "DisinfectionMethod";
            return View();
        }
        public ActionResult Create()
        {
            ViewBag.Active = "DisinfectionMethod";
            return View();
        }

        public ActionResult Edit()
        {
            ViewBag.Active = "DisinfectionMethod";
            return View();
        }
    }
}