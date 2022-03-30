using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _28strStr
    {
        public int StrStr(string haystack, string needle)
        {
            int i = 0;
            if (string.IsNullOrEmpty(needle))
                return 0;
            for (int j = 0; j < haystack.Length; j++)
            {
                if (needle[i] == haystack[j])
                {
                    i++;
                    if (i == needle.Length)
                        return j - needle.Length + 1;
                }
                else
                {
                    if (i > 0)
                    {
                        j = j - i;
                        i = 0;
                    }
                }
            }
            return -1;
        }
    }
}
