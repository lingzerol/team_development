using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.GetJWXT
{
    public class Gpa
    {
        public string coursecode;
        public string schoolyear;
        public  string coursename;
        public float credit;
        public float mark;
        public float gp;
        public string coursecategory;

       public Gpa(string schoolyear, string coursecode, string coursename, float credit, float mark,
            float gp, string coursecategory)
        {
            this.schoolyear = schoolyear;
            this.coursename = coursename;
            this.credit = credit;
            this.coursecode = coursecode;
            this.mark = mark;
            this.gp = gp;
            this.coursecategory = coursecategory;
        }
    }
}
