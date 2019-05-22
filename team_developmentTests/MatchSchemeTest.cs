using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib.GetJWXT;
namespace team_developmentTests
{
    /// <summary>
    /// MatchSchemeTest 的摘要说明
    /// </summary>
    [TestClass]
    public class MatchSchemeTest
    {
        public MatchSchemeTest()
        {
            //
            //TODO:  在此处添加构造函数逻辑
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性: 
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetMatchSchemeItemTest()
        {
            string html = "<FORM id=form1 method=post name=form1 action=default.aspx>\r\n<DIV><INPUT id=__VIEWSTATE type=hidden value=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ZTsnPuWtpuS4muWujOaIkOi/m+W6puaPkOmGkjwvc3Bhbj48L3RkPjx0ZCBzdHlsZT0ndGV4dC1hbGlnbjogcmlnaHQ7ICc+ICAgJm5ic3A7PC90ZD48dGQgc3R5bGU9J3dpZHRoOiAxNSU7Jz48L3RkPjwvdHI+PC90YWJsZT48ZGl2IGNsYXNzPSd5YW9xaXUnPjxkaXYgY2xhc3M9J2xhYmVsYyc+5oKo5aW977yM5oyJ54Wn5oKo55qE5Z+55YW75pa55qGI6KaB5rGCLOS9oOmcgOimgei+vuWIsOS7peS4i+eahOimgeaxgu+8jOaJjeiDveeUs+ivt+avleS4mu+8jOivt+WFs+azqOWtpuS5oOi/m+W6pu+8mjwvYnI+6K+05piO77ya6L2s5LiT5Lia5a2m55Sf5a2m5Lia6L+b5bqm5pWw5o2u5aaC5pyJ5LiN56ym77yM5Lul5a2m6Zmi6K6k5a6a55qE44CK6L2s5LiT5Lia5a2m55Sf6K++56iL6L2s5o2i55Sz6K+36KGo44CL5Li65YeG44CCPC9kaXY+PGRpdiBjbGFzcz0ndGFibGVkaXYnPjx0YWJsZSBjbGFzcz0nZm9ybV90YWJsZSc+ICA8dHI+ICAgIDx0aCBjb2xzcGFuPSczJz7lrabkuaDmqKHlnZc8L3RoPiAgICA8dGg+6KaB5rGCPC90aD4gICAgPHRoPuW3suS/rjwvdGg+ICAgIDx0aD7ov5jlt648L3RoPiAgPC90cj4gIDx0cj4gICAgPHRoIGNvbHNwYW49JzMnPuaAu+WtpuWIhjwvdGg+ICAgIDx0ZCBjbGFzcz0nbmVlZHMnPjE2MC4wMDwvdGQ+ICAgIDx0ZCBjbGFzcz0nc3R1ZHknPjExNy4wMDwvdGQ+ICAgIDx0ZCBjbGFzcz0nbGVmdHMnPjQzPC90ZD4gIDwvdHI+ICA8dHI+ICAgIDx0aCBjb2xzcGFuPSczJz7lv4Xkv648L3RoPiAgICA8dGQgY2xhc3M9J25lZWRzJz4xMDkuNTA8L3RkPiAgICA8dGQgY2xhc3M9J3N0dWR5Jz44OS4wMDwvdGQ+ICAgIDx0ZCBjbGFzcz0nbGVmdHMnPjIwLjU8L3RkPiAgPC90cj4gIDx0cj4gICAgPHRoIHJvd3NwYW49JzExJz7pgInkv648L3RoPiAgICA8dGggcm93c3Bhbj0nNyc+6YCa6K+G5pWZ6IKyPGJyIC8+PC90aD4gICAgPHRoPuiJuuacr+e0oOWFuzwvdGg+ICAgIDx0ZCBjbGFzcz0nbmVlZHMnPjIuMDwvdGQ+ICAgIDx0ZCBjbGFzcz0nc3R1ZHknPjIuMDA8L3RkPiAgICA8dGQgY2xhc3M9J2xlZnRzJz4wPC90ZD4gIDwvdHI+ICA8dHI+ICAgIDx0aD7mloflj7Llk7Lnsbs8L3RoPiAgICA8dGQgY2xhc3M9J25lZWRzJz40LjA8L3RkPiAgICA8dGQgY2xhc3M9J3N0dWR5Jz4yLjAwPC90ZD4gICAgPHRkIGNsYXNzPSdsZWZ0cyc+MjwvdGQ+ICA8L3RyPiAgPHRyPiAgICA8dGg+57uP566h5rOV57G7PC90aD4gICAgPHRkIGNsYXNzPSduZWVkcyc+Mi4wPC90ZD4gICAgPHRkIGNsYXNzPSdzdHVkeSc+Mi4wMDwvdGQ+ICAgIDx0ZCBjbGFzcz0nbGVmdHMnPjA8L3RkPiAgPC90cj4gIDx0cj4gICAgPHRoPuaVsOeQhuW3peexuzwvdGg+ICAgIDx0ZCBjbGFzcz0nbmVlZHMnPjwvdGQ+ICAgIDx0ZCBjbGFzcz0nc3R1ZHknPjwvdGQ+ICAgIDx0ZCBjbGFzcz0nbGVmdHMnPjwvdGQ+ICA8L3RyPiAgPHRyPiAgICA8dGg+55SfIOWRvSDnsbs8L3RoPiAgICA8dGQgY2xhc3M9J25lZWRzJz48L3RkPiAgICA8dGQgY2xhc3M9J3N0dWR5Jz48L3RkPiAgICA8dGQgY2xhc3M9J2xlZnRzJz48L3RkPiAgPC90cj4gIDx0cj4gICAgPHRoPuWFtiDlroMg57G7PC90aD4gICAgPHRkIGNsYXNzPSduZWVkcyc+OC4wPC90ZD4gICAgPHRkIGNsYXNzPSdzdHVkeSc+NC4wMDwvdGQ+ICAgIDx0ZCBjbGFzcz0nbGVmdHMnPjQ8L3RkPiAgPC90cj4gIDx0cj4gICAgPHRoPumAmuivhuWwj+iuoTwvdGg+ICAgIDx0ZCBjbGFzcz0nbmVlZHMnPjE2LjAwPC90ZD4gICAgPHRkIGNsYXNzPSdzdHVkeSc+MTAuMDA8L3RkPiAgICA8dGQgY2xhc3M9J2xlZnRzJz42PC90ZD4gIDwvdHI+ICA8dHI+ICAgIDx0aCBjb2xzcGFuPScyJz7ln7rnoYDmlZnogrI8L3RoPiAgICA8dGQgY2xhc3M9J25lZWRzJz4xMC4wMDwvdGQ+ICAgIDx0ZCBjbGFzcz0nc3R1ZHknPjguMDA8L3RkPiAgICA8dGQgY2xhc3M9J2xlZnRzJz4yPC90ZD4gIDwvdHI+ICA8dHI+ICAgIDx0aCBjb2xzcGFuPScyJz7kuJPkuJrmlZnogrI8L3RoPiAgICA8dGQgY2xhc3M9J25lZWRzJz4xOC41MDwvdGQ+ICAgIDx0ZCBjbGFzcz0nc3R1ZHknPjEwLjAwPC90ZD4gICAgPHRkIGNsYXNzPSdsZWZ0cyc+OC41PC90ZD4gIDwvdHI+ICA8dHI+ICAgIDx0aCBjb2xzcGFuPScyJz7ot6jkuJPkuJror77nqIs8L3RoPiAgICA8dGQgY2xhc3M9J25lZWRzJz4wLjA8L3RkPiAgICA8dGQgY2xhc3M9J3N0dWR5Jz48L3RkPiAgICA8dGQgY2xhc3M9J2xlZnRzJz4wLjA8L3RkPiAgPC90cj4gIDx0cj4gICAgPHRoIGNvbHNwYW49JzInPumAieS/ruWQiOiuoTwvdGg+ICAgIDx0ZCBjbGFzcz0nbmVlZHMnPjUwLjUwPC90ZD4gICAgPHRkIGNsYXNzPSdzdHVkeSc+MjguMDA8L3RkPiAgICA8dGQgY2xhc3M9J2xlZnRzJz4yMi41PC90ZD4gIDwvdHI+PC90YWJsZT48ZGl2PjxkaXYgY2xhc3M9J3VybGxpbmsnPuWFt+S9k+ivvueoi+S/ruivu+aDheWGteinge+8mumAieivvueuoeeQhuezu+e7n+S4i+eahDxhIGhyZWY9J1NlY3VyZS9QYWlLZVh1YW5LZS93ZnJtX1hrX1B5ZmFDeC5hc3B4Jz7lrabnlJ/ln7nlhbvmlrnmoYg8L2E+PC9kaXY+ZGQSBojSVVZgwkBMNwjbYFbmYSIWWg== name=__VIEWSTATE> </DIV>\r\n<DIV><INPUT id=__VIEWSTATEGENERATOR type=hidden value=CA0B0334 name=__VIEWSTATEGENERATOR> </DIV>\r\n<TABLE style=\"FONT-SIZE: large; WIDTH: 100%\" cellSpacing=0 cellPadding=3 border=0>\r\n<TBODY>\r\n<TR style=\"BACKGROUND-COLOR: rgb(97,161,205)\">\r\n<TD style=\"WIDTH: 20%\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<SPAN style=\"FONT-SIZE: large; HEIGHT: 28px; FONT-WEIGHT: bold; COLOR: white\">通知公告</SPAN> </TD>\r\n<TD style=\"TEXT-ALIGN: right\"><SPAN style=\"COLOR: white\"><A href=\"secure/GGGL/gggl_xtgg_index.aspx?DisplayOnly=Y\">更多&gt;&gt;</A></SPAN> </TD>\r\n<TD style=\"WIDTH: 15%\"></TD></TR>\r\n<TR id=trGG1>\r\n<TD colSpan=3 noWrap>&nbsp;&nbsp;&nbsp;&nbsp;<SPAN lang=EN-US style=\"FONT-FAMILY: Wingdings\">l</SPAN>&nbsp;&nbsp; <A id=hlGG1 href=\"secure/GGGL/gggl_xtgl_infoQry.aspx?DisplayOnly=Y&amp;RESOURCEID=122\" target=_blank>new~ 关于2018—2019学年第二学期全日制本科学生毕业及学位审核工作的通知(非常重要)</A>&nbsp;&nbsp;<SPAN id=lbGG1>教务处 2019-4-2</SPAN> </TD></TR>\r\n<TR id=trGG2>\r\n<TD colSpan=3 noWrap>&nbsp;&nbsp;&nbsp;&nbsp;<SPAN lang=EN-US style=\"FONT-FAMILY: Wingdings\">l</SPAN>&nbsp;&nbsp; <A id=hlGG2 href=\"secure/GGGL/gggl_xtgl_infoQry.aspx?DisplayOnly=Y&amp;RESOURCEID=121\" target=_blank>关于《国学入门》等通识教育选修课撤班的通知</A>&nbsp;&nbsp;<SPAN id=lbGG2>教务处 2019-2-28</SPAN> </TD></TR>\r\n<TR id=trGG3>\r\n<TD colSpan=3 noWrap>&nbsp;&nbsp;&nbsp;&nbsp;<SPAN lang=EN-US style=\"FONT-FAMILY: Wingdings\">l</SPAN>&nbsp;&nbsp; <A id=hlGG3 href=\"secure/GGGL/gggl_xtgl_infoQry.aspx?DisplayOnly=Y&amp;RESOURCEID=120\" target=_blank>关于《信息安全简史》等通识教育选修课撤班的通知</A>&nbsp;&nbsp;<SPAN id=lbGG3>教务处 2019-1-10</SPAN> </TD></TR>\r\n<TR id=trGG4>\r\n<TD colSpan=3 noWrap>&nbsp;&nbsp;&nbsp;&nbsp;<SPAN lang=EN-US style=\"FONT-FAMILY: Wingdings\">l</SPAN>&nbsp;&nbsp; <A id=hlGG4 href=\"secure/GGGL/gggl_xtgl_infoQry.aspx?DisplayOnly=Y&amp;RESOURCEID=103\" target=_blank>关于打印成绩单及在学证明的通知</A>&nbsp;&nbsp;<SPAN id=lbGG4>教务处 2017-6-23</SPAN> </TD></TR>\r\n<TR id=trGG5>\r\n<TD colSpan=3 noWrap>&nbsp;&nbsp;&nbsp;&nbsp;<SPAN lang=EN-US style=\"FONT-FAMILY: Wingdings\">l</SPAN>&nbsp;&nbsp; <A id=hlGG5 href=\"secure/GGGL/gggl_xtgl_infoQry.aspx?DisplayOnly=Y&amp;RESOURCEID=85\" target=_blank>《网络音乐欣赏》、《网络舞蹈欣赏》课程修读须知</A>&nbsp;&nbsp;<SPAN id=lbGG5>教务处 2015-9-16</SPAN> </TD></TR>\r\n<TR id=trGG6>\r\n<TD colSpan=3 noWrap>&nbsp;&nbsp;&nbsp;&nbsp;<SPAN lang=EN-US style=\"FONT-FAMILY: Wingdings\">l</SPAN>&nbsp;&nbsp; <A id=hlGG6 href=\"secure/GGGL/gggl_xtgl_infoQry.aspx?DisplayOnly=Y&amp;RESOURCEID=79\" target=_blank>关于调整打印成绩单及在学证明流程的通知</A>&nbsp;&nbsp;<SPAN id=lbGG6>教务处 2015-4-23</SPAN> </TD></TR>\r\n<TR id=trGG7>\r\n<TD colSpan=3 noWrap>&nbsp;&nbsp;&nbsp;&nbsp;<SPAN lang=EN-US style=\"FONT-FAMILY: Wingdings\">l</SPAN>&nbsp;&nbsp; <A id=hlGG7 href=\"secure/GGGL/gggl_xtgl_infoQry.aspx?DisplayOnly=Y&amp;RESOURCEID=39\" target=_blank>关于win7、vista操作系统无法浏览pdf文件的解决办法</A>&nbsp;&nbsp;<SPAN id=lbGG7>教务处 2012-1-5</SPAN> </TD></TR></TBODY></TABLE><BR><BR>\r\n<TABLE style=\"FONT-SIZE: large; WIDTH: 100%\" cellSpacing=0 cellPadding=3 border=0>\r\n<TBODY>\r\n<TR style=\"BACKGROUND-COLOR: rgb(97,161,205)\">\r\n<TD style=\"WIDTH: 20%\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<SPAN style=\"FONT-SIZE: large; HEIGHT: 28px; FONT-WEIGHT: bold; COLOR: white\">待办任务</SPAN> </TD>\r\n<TD style=\"TEXT-ALIGN: right\"><SPAN style=\"COLOR: white\"><A href=\"secure/GGGL/gggl_dbrw_index.aspx\">更多&gt;&gt;</A></SPAN> </TD>\r\n<TD style=\"WIDTH: 15%\"></TD></TR>\r\n<TR id=trrw0>\r\n<TD colSpan=3 noWrap>&nbsp;&nbsp;&nbsp;&nbsp;<SPAN lang=EN-US style=\"FONT-FAMILY: Wingdings\">l</SPAN>&nbsp;&nbsp; <SPAN id=Label2>暂无待办任务</SPAN> </TD></TR></TBODY></TABLE>\r\n<TABLE style=\"FONT-SIZE: large; WIDTH: 100%\" cellSpacing=0 cellPadding=3 border=0>\r\n<TBODY>\r\n<TR style=\"BACKGROUND-COLOR: rgb(97,161,205)\">\r\n<TD style=\"WIDTH: 50%\">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<SPAN style=\"FONT-SIZE: large; HEIGHT: 28px; FONT-WEIGHT: bold; COLOR: white\">学业完成进度提醒</SPAN></TD>\r\n<TD style=\"TEXT-ALIGN: right\">&nbsp;</TD>\r\n<TD style=\"WIDTH: 15%\"></TD></TR></TBODY></TABLE>\r\n<DIV class=yaoqiu>\r\n<DIV class=labelc>您好，按照您的培养方案要求,你需要达到以下的要求，才能申请毕业，请关注学习进度：<BR>说明：转专业学生学业进度数据如有不符，以学院认定的《转专业学生课程转换申请表》为准。</DIV>\r\n<DIV class=tablediv>\r\n<TABLE class=form_table>\r\n<TBODY>\r\n<TR>\r\n<TH colSpan=3>学习模块</TH>\r\n<TH>要求</TH>\r\n<TH>已修</TH>\r\n<TH>还差</TH></TR>\r\n<TR>\r\n<TH colSpan=3>总学分</TH>\r\n<TD class=needs>160.00</TD>\r\n<TD class=study>117.00</TD>\r\n<TD class=lefts>43</TD></TR>\r\n<TR>\r\n<TH colSpan=3>必修</TH>\r\n<TD class=needs>109.50</TD>\r\n<TD class=study>89.00</TD>\r\n<TD class=lefts>20.5</TD></TR>\r\n<TR>\r\n<TH rowSpan=11>选修</TH>\r\n<TH rowSpan=7>通识教育<BR></TH>\r\n<TH>艺术素养</TH>\r\n<TD class=needs>2.0</TD>\r\n<TD class=study>2.00</TD>\r\n<TD class=lefts>0</TD></TR>\r\n<TR>\r\n<TH>文史哲类</TH>\r\n<TD class=needs>4.0</TD>\r\n<TD class=study>2.00</TD>\r\n<TD class=lefts>2</TD></TR>\r\n<TR>\r\n<TH>经管法类</TH>\r\n<TD class=needs>2.0</TD>\r\n<TD class=study>2.00</TD>\r\n<TD class=lefts>0</TD></TR>\r\n<TR>\r\n<TH>数理工类</TH>\r\n<TD class=needs></TD>\r\n<TD class=study></TD>\r\n<TD class=lefts></TD></TR>\r\n<TR>\r\n<TH>生 命 类</TH>\r\n<TD class=needs></TD>\r\n<TD class=study></TD>\r\n<TD class=lefts></TD></TR>\r\n<TR>\r\n<TH>其 它 类</TH>\r\n<TD class=needs>8.0</TD>\r\n<TD class=study>4.00</TD>\r\n<TD class=lefts>4</TD></TR>\r\n<TR>\r\n<TH>通识小计</TH>\r\n<TD class=needs>16.00</TD>\r\n<TD class=study>10.00</TD>\r\n<TD class=lefts>6</TD></TR>\r\n<TR>\r\n<TH colSpan=2>基础教育</TH>\r\n<TD class=needs>10.00</TD>\r\n<TD class=study>8.00</TD>\r\n<TD class=lefts>2</TD></TR>\r\n<TR>\r\n<TH colSpan=2>专业教育</TH>\r\n<TD class=needs>18.50</TD>\r\n<TD class=study>10.00</TD>\r\n<TD class=lefts>8.5</TD></TR>\r\n<TR>\r\n<TH colSpan=2>跨专业课程</TH>\r\n<TD class=needs>0.0</TD>\r\n<TD class=study></TD>\r\n<TD class=lefts>0.0</TD></TR>\r\n<TR>\r\n<TH colSpan=2>选修合计</TH>\r\n<TD class=needs>50.50</TD>\r\n<TD class=study>28.00</TD>\r\n<TD class=lefts>22.5</TD></TR></TBODY></TABLE>\r\n<DIV>\r\n<DIV class=urllink>具体课程修读情况见：选课管理系统下的<A href=\"Secure/PaiKeXuanKe/wfrm_Xk_PyfaCx.aspx\">学生培养方案</A></DIV></FORM></DIV></DIV></DIV>";
            GetJWXT jwxt = GetJWXT.jwxt;
            MatchSchemeItem mci=jwxt.GetMatchSchemeItem(html);
            Assert.AreEqual(13, mci.lefts.Count);
            Assert.AreEqual(13, mci.needs.Count);
            Assert.AreEqual(13, mci.study.Count);
       
        }
    }
}
