using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFactory.Animations {
    public class AnimationCurve {

        private IList<Point> points = new List<Point>(); 

        public void Set(float time, float value) {
            points.Add(new Point(time, value));
            points = points.OrderBy(x => x.Time).ToList();
        }

        public float Evaluate(float time) {

            throw new NotImplementedException();

            Point a, b;
            //var e = points.Select(x => x.Time < time).Max<Point>(x => x.Time);

            return 0;
        }

        public override string ToString() {
            string res = "";

            foreach (Point point in points) {
                res += $"Time: {point.Time}, Value: {point.Value}\n";
            }

            return res;
        }

        private class Point {
            readonly public float Time;
            readonly public float Value;
            public Point(float t, float v) {
                Time = t; Value = v;
            }
        }
    }
}
