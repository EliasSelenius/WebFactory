using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebFactory.Framework;
using WebFactory.Framework.Components;
using WebFactory.Framework.Components.Standard;


namespace WebDemo.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public string Test() {
            Page page = new Page("My testing Page");

            page.InitTag(new Text("HelloWorld"), new Transform3D(290, 90));
            page.InitTag(new Text("Yo World"), new Transform3D(300, 100));
            page.InitTag(new Text("Hey Universe"), new Transform3D(280, 80));
            page.InitTag(new Text("Good Afternuun Multiverse"), new Transform3D(110, 95));


            return page.Render();
        }
    }

    public class Text : BaseComponent {

        private readonly string text;

        public Text(string t) {
            text = t;
        }

        protected override string Draw() {
            return $"<p>{text}</p>";
        }
    }
}