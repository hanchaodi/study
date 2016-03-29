using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _6._1_Server_Side_Validation.Models;

namespace _6._1_Server_Side_Validation.Controllers
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

        [HttpPost]
        public ActionResult Edit(ComanyInput input)
        {
            if(ModelState.IsValid)
            {
                return View("Success");
            }
            return View(new ComanyInput());
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View(new ComanyInput());
        }
    }
}