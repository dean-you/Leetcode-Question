using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    class _125ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            var sb = new StringBuilder();
            foreach (var c in s)
            {
                if (Char.IsLetterOrDigit(c))
                    sb.Append(Char.ToLower(c));
            }
            var str = sb.ToString();
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] != str[str.Length - 1 - i])
                    return false;
                if (i == str.Length / 2 || i == (str.Length / 2 + 1))
                    break;
            }
            return true;
        }
    }
}
