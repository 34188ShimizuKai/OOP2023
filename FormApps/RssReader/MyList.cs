using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssReader {
    class MyList {
        public string Title { get; set; }
        public string Link { get; set; }

        public MyList(string title, string link) {
            this.Title = title;
            this.Link = link;
        }

        public override string ToString() {
            return Title;
        }
    }
}
