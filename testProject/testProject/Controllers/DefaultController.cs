using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testProject.Controllers {
    public class DefaultController : Controller {
        //
        // GET: /Default/

        [HttpGet]
        public ActionResult Login() {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string login, string password) {
            if (login == "admin" && password == "admin") {
                //todo: redirect to feed controller
                Session["UserId"] = 1;
                return null;
            }
            else {
                ViewBag.ErrorMessage = "Пользователя с такими данными не существует!";
                return View();
            }
        }

    }
}