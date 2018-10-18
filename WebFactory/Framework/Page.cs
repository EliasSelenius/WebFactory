using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;

using WebFactory.Framework.Components;

namespace WebFactory.Framework {
    public class Page {
        List<Tag> tags = new List<Tag>();

        public string Title;

        public Page(string title) {
            Title = title;
        }

        public void InitTag(params BaseComponent[] comps) {
            Tag tag = new Tag("id" + Path.GetRandomFileName().Replace(".", ""));
            tag.AddComponents(comps);
            tags.Add(tag);
        }
        public void InitTags(int num, params BaseComponent[] comps) {
            for (int i = 0; i < num; i++) {
                InitTag(comps);
            }
        }

        public string Render() {
            string res =
                "<!DOCTYPE html>" +
                "<html>" +
                "<head>" +
                "<meta charset=\"utf-8\" />" +
                "<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">" +
                $"<title>{Title}</title>" + 
                "</head>" +
                "<body>";

            foreach (Tag tag in tags) {
                res += tag.Render();
            }

            res +=
                "</body>" +
                "</html>";

            return res;
        }
    }
}
