using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testProject.Controllers {
    public class AdministrationController : Controller {
        //
        // GET: /Administration/

        public ActionResult Index() {
            return View();
        }

        public ActionResult CitiesConfig() {
            return View();
        }

        public ActionResult Reports() {
            return View();
        }

        public ActionResult Planning() {
            return View();
        }

        public ActionResult Progress() {
            return View();
        }
    }
}