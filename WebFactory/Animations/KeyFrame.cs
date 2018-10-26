using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFactory.Animations {
    public class KeyFrame {
        public float Time;
        public Dictionary<string, object> Keys;
        public KeyFrame(float time) {
            Time = time;
        }
    }
}
