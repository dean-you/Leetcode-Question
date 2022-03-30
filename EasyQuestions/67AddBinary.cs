using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _67AddBinary
    {
        public string AddBinary(string a, string b)
        {
            var r = new StringBuilder();
            var temp = 0;
            var small = string.Empty;
            var big = string.Empty;
            if (a.Length > b.Length)
            {
                small = b;
                big = a;
            }
            else
            {
                small = a;
                big = b;
            }
            var difLen = big.Length - small.Length;
            for (int i = small.Length - 1; i >= 0; i--)
            {
                r.Insert(0, (int.Parse(small[i].ToString()) + int.Parse(big[i + difLen].ToString()) + temp) % 2);
                temp = (int.Parse(small[i].ToString()) + int.Parse(big[i + difLen].ToString()) + temp) / 2;
            }

            for (int i = difLen - 1; i >= 0; i--)
            {
                r.Insert(0, (int.Parse(big[i].ToString()) + temp) % 2);
                temp = (int.Parse(big[i].ToString()) + temp) / 2;
            }

            if (temp > 0)
                r.Insert(0, temp);

            return r.ToString();
        }
    }
}
