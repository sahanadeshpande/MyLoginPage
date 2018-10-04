using LoginFormDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginFormDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserLoginModel objUserLogin)
        {
            if (objUserLogin.UserName == "admin" && objUserLogin.Password == "admin")
                return RedirectToAction("WelcomePage");
            else
            {
                objUserLogin.Message = "Invalid UserName/Password";
                return View(objUserLogin);
            }

        }

        public ActionResult WelcomePage()
        {
            return View();
        }

    }
}
