using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_development.UI.JWXT
{
    public class JwxtSingleton
    {
        private static JwxtLogin jwxtLogin;

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
