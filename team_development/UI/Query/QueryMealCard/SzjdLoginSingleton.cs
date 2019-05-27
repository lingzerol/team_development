using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team_development.UI.Query.QueryMealCard
{
    public class SzjdLoginSingleton
    {
        private static SzjdLogin szjdLogin = null;

        public static SzjdLogin GetInstance(string username, string password, Refresh refresh)
        {
            if (szjdLogin == null)
            {
                szjdLogin = new SzjdLogin(username, password, refresh);
            }
            return szjdLogin;
        }

        public static void SetNull()
        {
            szjdLogin = null;
        }
    }
}
