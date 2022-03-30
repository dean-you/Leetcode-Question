using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _3LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var max = 0;
            var sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                var index = sb.ToString().IndexOf(s[i]);
                if (index >= 0)
                {
                    if (sb.Length > max)
                        max = sb.Length;
                    sb.Remove(0, index + 1);
                }
                sb.Append(s[i]);
            }
            if (sb.Length > max)
                max = sb.Length;
            return max;
        }
    }
}
