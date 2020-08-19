using Mini_CStructor.Business;
using Mini_CStructor.WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mini_CStructor.WebSite.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //private readonly IClassManager classManager;
        private readonly IUserManager userManager;

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                userManager.Register(registerModel.UserEmail, registerModel.UserPassword);

                return Redirect("~/");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult LogIn()
        {
            ViewData["ReturnUrl"] = Request.QueryString["returnUrl"];
            return View();
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