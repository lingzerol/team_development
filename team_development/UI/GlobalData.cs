using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using team_development.UI;
using Lib;
namespace team_development.UI
{
    public static class GlobalData
    {
        public static UserInfo.UserInfo userInfo;
        static GlobalData() {
            UserInfo.UserInfo user = (UserInfo.UserInfo)Storage.Load("UserInfo.xml");
            if (null == user) {
                user = new UserInfo.UserInfo();
            }
            GlobalData.userInfo = user;
        }
    }
}
