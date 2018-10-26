using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;

namespace WebFactory {
    
    public static class Css {

        


        public static string Grid(int cols, int rows) {
            string content = @"html, body { height: 100%; margin: 0; }";

            // init collumns:
            for (int c = 1; c <= cols; c++) {
                string tmp = $".col-{c}" + "{ \n width: " + ((100f / cols) * c).ToString() + "%; \n } \n";
                content += tmp.Replace(',', '.');
            }

            // for every collumn:
            if (cols != 0) {
                for (int i = 1; i <= cols; i++) {
                    content += $".col-{i},";
                }
                content = content.Remove(content.Length - 1);
                content += @"{ float: left; box-sizing: border-box; }";
            }
            
            // init rows:
            for (int r = 1; r <= rows; r++) {
                string tmp = $".row-{r}" + "{ \n height: " + ((100f / rows) * r).ToString() + "%; \n } \n";
                content += tmp.Replace(',', '.');
            }

            // for every row:
            if (rows != 0) {
                for (int i = 1; i <= rows; i++) {
                    content += $".row-{i},";
                }
                content = content.Remove(content.Length - 1);
                content += @"{ box-sizing: border-box; }";
            }
            


            // helper classes:
            content += @".col-max { width: 100%; }";
            content += @".col-half { width: 50%; }";
            content += @".row-max { height: 100%; }";
            content += @".row-half { height: 50%; }";

            return content;
        }


        //TODO: is there an instance where this doesent work? is there an easyer way to do this?
        public static string ApplyId(string idToApply, string css) {
            string id = " #" + idToApply + " ";
            string res = css;
            for (int i = 0; i < css.Length; i++) {
                char c = res[i];
                if (c.Equals('}')) {
                    res = res.Insert(i + 1, id);
                    i += id.Length;
                }
            }
            
            return res;
        }


        private static string FormatNumber(float num, string unit = "") {
            return (num + unit).Replace(",", ".");
        }


        public static class Units {
            public const string Percent = "%";
            public const string Pixels = "px";

            public const string Degrees = "deg";
            public const string Radians = "rad";
        }

        public static class Attribute {
            public static string Transform(Nums.Transform t) {
                var r = t.Rotation.AxisAngle;
                return $"transform: " +
                    $"translate3d({FormatNumber(t.Position.x, Units.Pixels)}, " +
                                $"{FormatNumber(t.Position.y, Units.Pixels)}, " +
                                $"{FormatNumber(t.Position.z, Units.Pixels)}) " +
                    $"rotate3d({FormatNumber(r.x)}, " +
                             $"{FormatNumber(r.y)}, " +
                             $"{FormatNumber(r.z)}, " +
                             $"{FormatNumber(r.w, Units.Radians)}) " +
                    $"scale3d({FormatNumber(t.Scale.x)}, " +
                            $"{FormatNumber(t.Scale.y)}, " +
                            $"{FormatNumber(t.Scale.z)});";
            }

        }


        public static class Animation {
            public static string KeyFrames(string name, Animations.Animation anim) {
                return null;
            }
        }

    }
}
