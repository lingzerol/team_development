using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using team_development.UI.CourseSelection;
using team_development.UI.UserInfo;
namespace team_development.Lib
{
    public enum MenuType { JWXT, AFL, Forum, Query, UserInfo };
    public enum SubMenuType { C_S,MatchScheme,Q_Mark,Q_Inform,Q_Employ,Q_MealCard,Q_Cost}
    public class MenuGetter
    {
        
        static MenuGetter() {
        }
        public static Form GetMenu(MenuType MenuId,SubMenuType SubMenu=0) {
            Form result=new Form();
            switch (MenuId) {
                case MenuType.JWXT:
                    switch (SubMenu) {
                        case SubMenuType.C_S:
                            result = new CourseSelection();
                            break;
                        case SubMenuType.MatchScheme:
                            result = new MatchScheme();
                            break;
                        default:break;
                            //error processing
                    }
                    break;
                case MenuType.AFL:
                    break;
                case MenuType.Forum:
                    break;
                case MenuType.Query:
                    switch (SubMenu) {
                        case SubMenuType.Q_Mark:
                            break;
                        case SubMenuType.Q_Inform:
                            break;
                        case SubMenuType.Q_Employ:
                            break;
                        case SubMenuType.Q_MealCard:
                            break;
                        case SubMenuType.Q_Cost:
                            break;
                        default:
                            //error processing
                            break;
                    }
                    break;
                case MenuType.UserInfo:
                    result = new UserInfoDisplay();
                    break;
                default:
                    //error processing
                    break;
            }
            result.TopLevel = false;
            result.FormBorderStyle = FormBorderStyle.None;
            result.Dock = System.Windows.Forms.DockStyle.Fill;
            return result;
        }

    }
   
}
