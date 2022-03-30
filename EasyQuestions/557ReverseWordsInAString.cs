using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _557ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {
            var words = s.Split(' ');
            var sb = new StringBuilder();
            foreach (var word in words)
            {
                var str = word.Reverse();
                sb.Append(str.ToArray());
                sb.Append(' ');
            }

            if (sb.Length > 1)
                sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        private char[] ReverseString(char[] s)
        {
            var left = 0;
            var right = s.Length - 1;
            while (left < right)
            {
                var temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }
            return s;
        }
    }
}
