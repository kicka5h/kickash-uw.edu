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
        private readonly IUserManager userManager;

        public HomeController(IClassManager classManager, IUserManager userManager)
        {
            this.classManager = classManager;
            this.userManager = userManager;
        }

        public ActionResult Classes()
        {
            ViewBag.Message = "Sign up for classes here.";

            var classes = classManager.Classes
                                    .Select(t => new WebSchool.Website.Models.ClassModel(t.ClassId, t.ClassName, t.ClassDescription, t.ClassPrice))
                                    .ToArray();
            var model = classes.Select(t => new Models.ClassViewModel.ClassRegisterModel
            {
                ClassId = t.ClassId,
                ClassName = t.ClassName,
                ClassDescription = t.ClassDescription,
                ClassPrice = t.ClassPrice
            }).ToArray();

            return View(model);
        }

        public ActionResult Registration()
        {
            ViewBag.Message = "You've registered for a class!";
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

        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(LoginModel loginModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = userManager.LogIn(loginModel.UserEmail, loginModel.UserPassword);

                if (user == null)
                {
                    ModelState.AddModelError("", "User name and password do not match.");
                }
                else
                {
                    Session["User"] = new WebSchool.Website.Models.UserModel
                    {
                        UserId = user.UserId,
                        UserEmail = user.UserEmail
                    };

                    System.Web.Security.FormsAuthentication.SetAuthCookie(
                        loginModel.UserEmail, false);

                    return Redirect(returnUrl ?? "~/");
                }
            }

            return View(loginModel);
        }

        public ActionResult LogOff()
        {
            Session["User"] = null;
            System.Web.Security.FormsAuthentication.SignOut();

            return Redirect("~/");
        }

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
    }
}