using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDWTAssignmentWaterQuality.Controllers
{
    public class SystemsController : Controller
    {
        // GET: /Systems/Index?id=5
        // where id is the personID
        public ActionResult Index()
        {
            ViewBag.Active = "Systems";
            return View();
        }

        // GET: /Systems/Details?id=5
        // where id is the vehicleID
        public ActionResult Details()
        {
            ViewBag.Active = "Systems";
            return View();
        }      
    }
}