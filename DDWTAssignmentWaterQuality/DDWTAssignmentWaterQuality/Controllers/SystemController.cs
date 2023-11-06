using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDWTAssignmentWaterQuality.Controllers
{
    public class SystemController : Controller
    {
        // GET: System
        public ActionResult Index()
        {
            ViewBag.Active = "System";
            return View();
        }
    }
}