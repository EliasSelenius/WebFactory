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
            Page page = new Page("My WebFactory App");

            page.InitTag(new MyComp(), new MyComp());

            page.InitTag();

            Console.WriteLine(page.Render().ToString());

            Console.Read();
        }
    }

    class MyComp : BaseComponent {
        protected override string Draw() {
            return "<h1> HEllo World</h1>";
        }
    }
}
