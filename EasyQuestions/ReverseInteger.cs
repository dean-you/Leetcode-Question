using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            if (x == 0) return 0;
            var s = "";
            if (x < 0)
                s = x.ToString().Substring(1);
            else
                s = x.ToString();
            var result = 0;
            if (int.TryParse(s.Reverse().ToArray(), out result))
                return x < 0 ? - result : result;
            else return 0;
        }
    }
}
