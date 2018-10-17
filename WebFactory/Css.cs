using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;

namespace WebFactory {
    public static class Css {

        public static IHtmlString Grid(int cols, int rows) {
            string content = @"<style> html, body { height: 100%; margin: 0; }";

            for (int c = 1; c <= cols; c++) {
                content += $".col-{c}" + "{ \n width: " + ((100f / cols) * c).ToString() + "%; \n } \n";
            }

            for (int i = 1; i <= cols; i++) {
                content += $".col-{i},";
            }
            content = content.Remove(content.Length - 1);
            content += @"{ float: left; }";


            for (int r = 1; r <= rows; r++) {
                content += $".row-{r}" + "{ \n height: " + ((100f / rows) * r).ToString() + "%; \n } \n";
            }

            content += @".row-max { height: 100%; }";

            content += @"</style>";
            return new HtmlString(content);
        }


        public static string ApplyId(string id, string css) {
            string res = css;
            for (int i = 0; i < css.Length; i++) {
                char c = res[i];
                if (c.Equals('}')) {
                    res = res.Insert(i, id);
                }
            }
            
            return res;
        }
    }
}
