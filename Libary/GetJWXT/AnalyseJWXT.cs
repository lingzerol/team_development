using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lib.GetJWXT
{
    public class AnalyseJWXT
    {
        public static MatchSchemeItem GetMatchSchemeItem()
        {
            List<string> needs = new List<string>();
            List<string> study = new List<string>();
            List<string> lefts = new List<string>();
            string filepath = System.AppContext.BaseDirectory + @"\credit.txt";
            if (!File.Exists(filepath))
            {
                return null;
            }
            StreamReader s = File.OpenText(filepath);
            
            string var = null;
            int i = 0;
            while ((var = s.ReadLine()) != null){
                int sign = i % 3;
                switch (sign)
                {
                    case 0:
                        needs.Add(var);
                        break;
                    case 1:
                        study.Add(var);
                        break;
                    case 2:
                        lefts.Add(var);
                        break;
                }
                i++;
            }

            s.Close();
            MatchSchemeItem matchSchemeItem = new MatchSchemeItem(needs, study, lefts);
            return matchSchemeItem;

        }
    }
}
