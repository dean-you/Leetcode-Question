using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _9PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;
            int secondReversedHalfNumber = 0;
            while (x > secondReversedHalfNumber)
            {
                secondReversedHalfNumber = secondReversedHalfNumber * 10 + x % 10;
                x = x / 10;
            }

            return (x == secondReversedHalfNumber) || x == secondReversedHalfNumber / 10;
        }
    }
}
