using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSchool.Business;
using WebSchool.Website.Models;

namespace WebSchool.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClassManager classManager;
        public HomeController(IClassManager classManager)
        {
            this.classManager = classManager;
        }

        public ActionResult Classes()
        {
            var classes = (from t in classManager.Classes() select new Business.ClassModel
            {
                ClassId = t.ClassId,
                ClassName = t.ClassName,
                ClassDescription = t.ClassDescription,
                ClassPrice = t.ClassPrice
            }).ToList();

            return View(classes);
        }
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
    }
}