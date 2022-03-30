using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _8StringToInteger
    {
        public int MyAtoi(string s)
        {
            s = s.TrimStart();
            if (string.IsNullOrEmpty(s))
                return 0;
            var start = 0;
            var positive = true;
            if (s[0] == '-')
                positive = false;
            if (s[0] == '+' || s[0] == '-')
                start = 1;
            var sb = new StringBuilder();
            for (int i = start; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                    sb.Append(s[i]);
                else break;
            }

            var result = 0;
            if (sb.Length == 0)
                return result;
            if (int.TryParse(sb.ToString(), out result))
                return positive ? result : -result;
            else return positive ? int.MaxValue : int.MinValue;
        }
    }
}
