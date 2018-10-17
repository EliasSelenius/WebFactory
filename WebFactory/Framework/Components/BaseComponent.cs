using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;

namespace WebFactory.Framework.Components {
    public abstract class BaseComponent {

        protected Tag tag;

        public void Init(Tag t) {
            tag = t;
        }

        internal string Render() {
            return Draw();
        }

        protected abstract string Draw();
    }
}
