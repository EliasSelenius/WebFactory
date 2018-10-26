using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFactory.Animations {
    public class Animation {
        private IList<KeyFrame> Keys;

        public void AddKey(float time, dynamic data) {
            Keys.Add(new KeyFrame(time));
        }

        public dynamic Evaluate() {
            return null;
        }
    }
}
