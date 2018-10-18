using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFactory.Framework.Components.Standard {
    public class Transform3D : BaseComponent {
        private readonly float x, y;

        public Transform3D(float X, float Y) {
            x = X; y = Y;
        }

        protected override string Draw() {
            return "<style>" +
                   $"#{tag.Id}" +
                   "{" +
                   "position: absolute;" +
                   $"transform: translate({x}px, {y}px);" +
                   "}" +
                   "</style>";
        }
    }
}
