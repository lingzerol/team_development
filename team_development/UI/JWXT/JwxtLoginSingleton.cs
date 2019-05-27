using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team_development.UI.JWXT
{
    public class JwxtLoginSingleton
    {
        private static JwxtLogin jwxtLogin = null;

        public static JwxtLogin GetInstance(string username, string password, Refresh refresh)
        {
            if(jwxtLogin == null)
            {
                jwxtLogin = new JwxtLogin(username, password, refresh);
            }
            return jwxtLogin;
        }

        public static void SetNull()
        {
            jwxtLogin = null;
        }
    }
}
