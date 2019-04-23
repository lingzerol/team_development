using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using team_development.UI.CourseSelection;
using team_development.UI.UserInfo;
using team_development.UI.Absence;
using team_development.UI.GPAandCardInquiry;
using team_development.UI.InqueryEmploy;
using team_development.UI.InqueryInform;
namespace team_development.Lib
{
    public enum MenuType { JWXT, Absence, Forum, Query, UserInfo };
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
                            //result = new MatchScheme();
                            break;
                        default:break;
                            //error processing
                    }
                    break;
                case MenuType.Absence:
                    result = new AbsenceInput();
                    break;
                case MenuType.Forum:
                    break;
                case MenuType.Query:
                    switch (SubMenu) {
                        case SubMenuType.Q_Mark:
                            result = new GpaInquiry();
                            break;
                        case SubMenuType.Q_Inform:
                            result = new InquiryNotification();
                            break;
                        case SubMenuType.Q_Employ:
                            result = new InquiryOffer();
                            break;
                        case SubMenuType.Q_MealCard:
                            result = new MealcardInquiry();
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
            return result;
        }

    }
   
}
