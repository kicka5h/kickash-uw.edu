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
            ViewBag.Message = "Sign up for classes here.";

            var classes = classManager.Classes
                                    .Select(t => new WebSchool.Website.Models.ClassModel(t.ClassId, t.ClassName, t.ClassDescription, t.ClassPrice))
                                    .ToArray();
            var model = new ClassViewModel { Classes = classes };

            return View(model);
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