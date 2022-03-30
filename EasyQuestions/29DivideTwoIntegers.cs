using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestions
{
    public class _29DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            var positive = (dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0);
            var result = 0;
            if (dividend > 0)
            {
                if (divisor > 0)
                    dividend = dividend - divisor;
                else dividend = dividend + divisor;
                while (dividend >= 0)
                {
                    if (divisor > 0)
                        dividend = dividend - divisor;
                    else dividend = dividend + divisor;
                    result++;
                }
            }
            else
            {
                if (divisor > 0)
                    dividend = dividend + divisor;
                else dividend = dividend - divisor;
                while (dividend <= 0)
                {
                    if (divisor > 0)
                        dividend = dividend + divisor;
                    else dividend = dividend - divisor;
                    if (result != int.MaxValue)
                        result++;
                }
            }
            return positive ? result:-result;
        }

        public int Divide1(int x, int y)
        {
            long j = 0;
            if (y == 0) return int.MaxValue;
            bool isNegative = x > 0 ^ y > 0;
            long dividend = Math.Abs((long)x);
            long divisor = Math.Abs((long)y);
            if (divisor != 1)
            {
                for (long i = divisor; i <= dividend; i = i + divisor)
                {
                    j++;
                }
            }
            else
            {
                j = dividend;
            }
            j *= isNegative ? -1 : 1;
            if (j > int.MaxValue || j < int.MinValue) return int.MaxValue;

            return (int)j;
        }
    }

}
