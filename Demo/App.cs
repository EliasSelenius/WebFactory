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
