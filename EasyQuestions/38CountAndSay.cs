using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _38CountAndSay
    {
        public string CountAndSay(int n)
        {
            if (n == 1)
                return "1";
            var str = CountAndSay(n-1);
            var res = ConvertToDigitalString(str);
            return res;
        }

        private string ConvertToDigitalString(string str)
        {
            var res = new StringBuilder();
            Char pre = str[0];
            var count = 0;
            foreach (var item in str)
            {
                if (item == pre)
                {
                    count++;
                }
                else
                {
                    res.Append(count);
                    res.Append(pre);
                    pre = item;
                    count = 1;
                }
            }
            res.Append(count);
            res.Append(pre);
            return res.ToString();
        }
    }
}
