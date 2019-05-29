using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team_development.UI.Search
{
    public class Info
    {
        private String time;
        private String url;
        private String title;
        public Info(String mytitle, String mytime, String myurl)
        {
            time = mytime;
            url = myurl;
            title = mytitle;
        }
        public String getTime()
        {
            return time;
        }
        public String getUrl()
        {
            return url;
        }
        public String getTitle()
        {
            return title;
        }
    }
}