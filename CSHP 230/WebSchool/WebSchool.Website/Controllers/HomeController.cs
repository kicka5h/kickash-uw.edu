using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebSchool.Business;
using WebSchool.Website.Models;

namespace WebSchool.Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClassManager classManager;
        private readonly IUserManager userManager;
        private readonly IUserClassManager userClassManager;

        public HomeController(IClassManager classManager, IUserManager userManager, IUserClassManager userClassManager)
        {
            this.classManager = classManager;
            this.userManager = userManager;
            this.userClassManager = userClassManager;
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
            ViewBag.Message = "You've signed up for the classes below.";
            return View();
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Click the Classes tab to get started.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Webschool is an online class project for C# certification at UW.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Nothing here yet.";

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
            return View(new RegisterModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                userManager.Register(registerModel.Email, registerModel.Password);


                return RedirectToAction("Classes", "Home");
            }
            else
            {
                return View();
            }
        }

        private Models.UserModel GetLoggedOnUser()
        {
            if (User.Identity.IsAuthenticated)
            {
                return JsonConvert.DeserializeObject<Models.UserModel>(HttpContext.User.Identity.Name);
            }
            else
            {
                return null;
            }
        }

        /*
        private List<Models.UserClassModel> GetUserClasses()
        {
            var user = GetLoggedOnUser();
            return userClassManager.GetUserClasses(user.UserId).ToList();
        }
        */
    }
}