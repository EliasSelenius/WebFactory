using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebFactory.Framework;
using WebFactory.Framework.Components;

namespace WebDemo.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Test() {
            Page page = new Page("My testing Page");

            page.InitTag();

            return Content(page.Render());
        }
    }
}