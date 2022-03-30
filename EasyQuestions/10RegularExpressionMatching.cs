using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _10RegularExpressionMatching
    {
        public bool IsMatch(string s, string p)
        {
            var i = 0;
            var j = 0;
            while (i < s.Length && j < p.Length)
            {
                if (s[i] == p[j])
                {
                    i++;
                    j++;
                }
                else if (p[j] == '.')
                {
                    i++;
                    j++;
                }
                else if (p[j] == '*')
                {
                    if (s[i] == p[j - 1] || p[j - 1] == '.')
                    {
                        i++;
                        j++;
                    }
                    else
                        return false;
                }
                else if (s[i] == s[i - 1] && p[j - 1] == '*')
                {
                    i++;
                }
                else
                    return false;
            }

            if (i == s.Length && j > p.Length)
                return true;
            else
                return false;
        }
    }
}
