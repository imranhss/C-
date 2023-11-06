using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDWTAssignmentWaterQuality.Controllers
{
    public class ParameterController : Controller
    {
        // GET: /Parameter/Index?id=5
        // where id is the paramID
        public ActionResult Index()
        {
            ViewBag.Active = "Parameter";
            return View();
        }

        // GET: /Parameter/Details?id=5
        // where id is the paramID
        public ActionResult Details()
        {
            ViewBag.Active = "Parameter";
            return View();
        }

        // GET: /Parameter/Create?id=5
        // where id is the paramID
        public ActionResult Create()
        {
            ViewBag.Active = "Parameter";
            return View();
        }

        // GET: /Parameter/Edit?id=5
        // where id is the paramID
        public ActionResult Edit()
        {
            ViewBag.Active = "Parameter";
            return View();
        }
    }
}