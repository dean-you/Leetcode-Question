using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class LongestPalindrome
    {
        public string LongestPalindrome2(string s)
        {
            if (s == "" || s.Length <= 1)
                return s;
            int length = 0, start = 0;
            var mid = s.Length % 2 == 0 ? s.Length / 2 - 1 : s.Length / 2;
            for (int i = mid; i >= 0; i--)
            {
                int evenLength = PalindromeLength(s, i, i+1);
                int oddLength = PalindromeLength(s, i, i);
                int currentLength = Math.Max(evenLength, oddLength);
                if (currentLength > length)
                {
                    length = currentLength;
                    start = i - (length - 1) / 2;
                    if (length >= 2 * (i + 1))
                        break;
                }
            }

            for (int i = mid+1; i < s.Length - 1; i++)
            {
                int evenLength = PalindromeLength(s, i, i + 1);
                int oddLength = PalindromeLength(s, i, i);
                int currentLength = Math.Max(evenLength, oddLength);
                if (currentLength > length)
                {
                    length = currentLength;
                    start = i - (length - 1) / 2;
                    if (length >= 2 * (i + 1))
                        break;
                }
            }
            return s.Substring(start, length); 
        }



        public string LongestPalindrome1(string s)
        {
            if (s == "" || s.Length <= 1)
                return s;
            int length = 0, start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int evenLength = PalindromeLength(s, i, i + 1);
                int oddLength = PalindromeLength(s, i, i);
                int currentLength = Math.Max(evenLength, oddLength);

                if (currentLength > length)
                {
                    length = currentLength;
                    start = i - (length - 1) / 2;
                }
            }

            return s.Substring(start, length);
        }

        private int PalindromeLength(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return right - left - 1; // (right+1) - (left-1) - 1
        }
    }
}
