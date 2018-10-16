using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFactory {
    public static class Css {

        public static string Grid(int cols, int rows) {
            string content = @"html, body { height: 100%; }";

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


            return content;
        }
    }
}
