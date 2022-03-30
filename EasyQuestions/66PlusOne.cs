using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _66PlusOne
    {
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i>=0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i] = digits[i] + 1;
                    return digits;
                }
            }

            var newDigits = new int[digits.Length + 1];
            for (int i = 0; i < newDigits.Length; i++)
            {
                newDigits[i] = 0;
            }
            newDigits[0] = 1;
            return newDigits;
        }

    }
}
