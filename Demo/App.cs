using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebFactory.Framework;
using WebFactory.Framework.Components;

namespace Demo {
    class App {
        static void Main() {


            Console.WriteLine(WebFactory.Css.Attribute.Transform(new Nums.Transform(), WebFactory.Css.Units.Percent));

            Console.Read();

            var anim = new WebFactory.Animations.AnimationCurve();
            anim.Set(0, 1);
            anim.Set(1, 0.5f);
            anim.Set(.5f, 1);
            Console.WriteLine(anim);

            Console.Read();


            Console.WriteLine(WebFactory.Css.Grid(4, 4));

            Console.Read();

            Page page = new Page("My WebFactory App");

            page.InitTag(new MyComp(), new MyComp());

            page.InitTag();

            Console.WriteLine(page.Render().ToString());

            Console.WriteLine();

            string css =
                "h1 { color: red; }" +
                "div { background-color: green; }";



            Console.WriteLine(WebFactory.Css.ApplyId("Container", css));


            Console.Read();
        }
    }

    class MyComp : BaseComponent {
        protected override string Draw() {
            return "<h1> HEllo World</h1>";
        }
    }
}
