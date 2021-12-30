using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DXWebApp.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult GetPartialView(string itemName) {
            return RedirectToAction(itemName);
        }

        public ActionResult CallbackPanelPartial(string itemName) {
            ViewData["ActionName"] = itemName;
            return PartialView();
        }

        public ActionResult View1Partial() {
            return PartialView();
        }

        public ActionResult View2Partial() {
            return PartialView();
        }

        public ActionResult View3Partial() {
            return PartialView();
        }

        public ActionResult View4Partial() {
            return PartialView();
        }
    }
}