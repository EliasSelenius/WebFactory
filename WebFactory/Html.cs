using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WebFactory {
    public static class Html {

        private static Color color;

        public static void Fill(Color c) {
            color = c;
        }

        public static IHtmlString Rect(float x, float y, float w, float h) {


            string res = $"<div style=\"transform: translate({x}px, {y}px); " +
                                      $"width: {w}px;" +
                                      $"height: {h}px;" +
                                      $"background-color: rgb({color.R}, {color.G}, {color.B});" +
                                      $"position: absolute;\"></div>";

            return new System.Web.HtmlString(res);
        }
    }
}
