using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _118PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> r = new List<IList<int>>();
            for (int i = 1; i <= numRows; i++)
            {
                var l = new List<int>();
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i)
                        l.Add(1);
                    else
                    {
                        l.Add(r[i - 2][j - 2] + r[i - 2][j - 1]);
                    }
                }
                r.Add(l);
            }
            return r;
        }
    }
}
