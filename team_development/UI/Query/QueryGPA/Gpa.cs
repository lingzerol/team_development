using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team_development.UI.Query.QueryGPA
{
    public class Gpa
    {
        string schoolyear;
        string semester;
        string coursename;
        float credit;
        float mark;
        float gp;
        string coursecategory;

        public Gpa(string schoolyear, string semester, string coursename, float credit, float mark,
            float gp, string coursecategory){
            this.schoolyear = schoolyear;
            this.semester = semester;
            this.coursename = coursename;
            this.credit = credit;
            this.mark = mark;
            this.gp = gp;
            this.coursecategory = coursecategory;
            }
    }
}
