﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebFactory;
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

            page.InitTag(new Text("HelloWorld"));
            page.InitTag(new Text("Yo World"));
            page.InitTag(new Text("Hey Universe"));
            page.InitTag(new Text("Good Afternuun Multiverse"));



            return page.Render();
        }
    }

    public class Text : BaseComponent {

        private readonly string text;

        public Text(string t) {
            text = t;
        }

        

        protected override string Draw() {

            var t = new Nums.Transform();

            t.Position.Set(100, 400, 0);
            t.Rotate(0, new Random().Next(-80, 80), 0);
            t.Scale = Nums.Vec3.One * 100;

            return $"<p>{text}</p>" +
                "<style> " + $"#{tag.Id}" + "{" +
                $"{ Css.Attribute.Transform(t) } " +
                $"text-align: center;" +
                "}" +
                "</style>";
        }
    }
}