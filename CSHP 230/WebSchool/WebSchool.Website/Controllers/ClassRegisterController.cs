using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSchool.Website.Controllers
{
    public class ClassRegisterController : Controller
    {
        // GET: ClassRegister
        public ActionResult ClassRegister()
        {
            ViewBag.Message = "Register for your class here.";
            return View();
        }
    }
}