using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team_development.UI.UserInfo
{
    [Serializable]
    public class UserInfo
    {
        private string studentNumber;
        private string studentName;
        private string dormNumber;
        private string sZJDPassword;
        private string jWXTPassword;
        private int college;
        public UserInfo(){
            studentNumber = null;
            studentName = "";
            dormNumber = null;
            sZJDPassword = null;
            jWXTPassword = null;
            College = -1;
        }
        public string StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string DormNumber { get => dormNumber; set => dormNumber = value; }
        public string SZJDPassword { get => sZJDPassword; set => sZJDPassword = value; }
        public string JWXTPassword { get => jWXTPassword; set => jWXTPassword = value; }
        public int College { get => college; set => college = value; }
    }
}
